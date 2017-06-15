﻿using System;
using System.Windows.Forms;
using BrightIdeasSoftware;
using MeshViewer.Memory.Entities;
using System.Collections.Generic;
using System.Drawing;
using MeshViewer.Properties;
using MeshViewer.Memory.Enums;

namespace MeshViewer.Interface.Controls
{
    public partial class EntityExplorer : UserControl
    {
        public EntityExplorer()
        {
            InitializeComponent();

            splitContainer2.Panel1Collapsed = !FilterEnabled;
            olvColumn1.CellPadding = new Rectangle(4, 4, 4, 4);
        }

        private bool _filterEnabled;
        public bool FilterEnabled
        {
            get { return _filterEnabled; }
            set
            {
                if (_filterEnabled == value)
                    return;

                _filterEnabled = value;
                splitContainer2.Panel1Collapsed = !value;
                _filterBox.Visible = value;
            }
        }

        /// <summary>
        /// Triggered when an entity is removed from the local list of objects.
        /// </summary>
        /// <param name="instance">The instance that is being removed.</param>
        public void OnDespawn(CGObject_C instance)
        {
            if (entityGrid.SelectedObjects?.Length == 0)
                return;

            var selectedObject = entityGrid.SelectedObject as CGObject_C;
            if (instance.OBJECT_FIELD_GUID == selectedObject.OBJECT_FIELD_GUID)
                entityGrid.BeginInvoke((Action)(() => { entityGrid.SelectedObject = null; }));
        }

        public void SetFilterSource<T>()
        {
            if (!typeof(T).IsEnum)
                throw new InvalidOperationException();

            _filterBox.Items.AddRange(Enum.GetNames(typeof(T)));
        }

        /// <summary>
        /// Assigns a filter to the list view.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filter"></param>
        public void SetFilter<T>(Predicate<T> filter) where T : CGObject_C
        {
            listView1.ModelFilter = new ModelFilter(o => FilterEnabled ? filter(o as T) : true);
        }

        public string FilterValue => !string.IsNullOrEmpty(_filterBox.Text) ?
            _filterBox.Text :
            (_filterBox.SelectedIndex != -1 ? _filterBox.Items[_filterBox.SelectedIndex] as string : string.Empty);

        /// <summary>
        /// Triggered when an entity has been updated.
        /// </summary>
        /// <param name="instance">The currently updated instance.</param>
        public void OnUpdate(CGObject_C instance)
        {
            if (entityGrid.SelectedObjects?.Length == 0)
                return;
            
            // Force the property grid to re-load values.
            var selectedObject = entityGrid.SelectedObject as CGObject_C;
            if (instance.OBJECT_FIELD_GUID == selectedObject.OBJECT_FIELD_GUID)
                entityGrid.BeginInvoke((Action)(() => { entityGrid.SelectedObjects = entityGrid.SelectedObjects; }));
        }

        /// <summary>
        /// Assigns a generic renderer to this control.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="renderer"></param>
        public void SetRenderer<T, U>(T renderer) where T : ObjectListRenderer<U> where U : CGObject_C
        {
            olvColumn1.Renderer = renderer;
            renderer.TitleFont = new Font("Tahoma", 12.0f, FontStyle.Bold);

            renderer.BindExtra(olvColumn1);
        }

        /// <summary>
        /// Assigns a data source to the list view.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="elements"></param>
        public void SetDataSource<T>(IEnumerable<T> elements) where T : CGObject_C
        {
            if (olvColumn1.Renderer == null)
                throw new InvalidOperationException("Bind a renderer before assigning objects!");

            if (olvColumn1.Renderer.GetType().IsGenericType)
            {
                var genericType = olvColumn1.Renderer.GetType().GetGenericArguments()[0];
                if (!(genericType.IsAssignableFrom(typeof(T))))
                    throw new InvalidOperationException("Type mismatch between the renderer and the provided collection!");
            }
            listView1.Objects = elements;
        }

        /// <summary>
        /// Triggered when an element of the list view is selected, displaying all properties
        /// in the grid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCellClick(object sender, CellClickEventArgs e)
        {
            entityGrid.SelectedObject = e.Model;
        }
    }

    public abstract class ObjectListRenderer<T> : DescribedTaskRenderer where T : CGObject_C
    {
        public Type Type => typeof(T);

        public override string GetDescription(object model) => GetDescription(model as T);

        protected abstract string GetDescription(T model);
        public virtual void BindExtra(OLVColumn column) { }
    }

    public sealed class GameobjectListRenderer : ObjectListRenderer<CGGameObject_C>
    {
        protected override string GetDescription(CGGameObject_C model)
        {
            return $"Type: {model.ObjectType}";
        }
    }

    /// <summary>
    /// A renderer suited for rendering both players and units.
    /// </summary>
    public sealed class EntityListRenderer : ObjectListRenderer<CGUnit_C>
    {
        public override void BindExtra(OLVColumn column)
        {
            column.ImageGetter = GetClassImage;
        }

        public object GetClassImage(object model)
        {
            if (!(model is CGPlayer_C))
                return null;

            var player = model as CGUnit_C;
            switch (player.Class)
            {
                case Class.Warrior:     return new Bitmap(Resources.Warrior,     new Size(45, 45));
                case Class.Paladin:     return new Bitmap(Resources.Paladin,     new Size(45, 45));
                case Class.Hunter:      return new Bitmap(Resources.Hunter,      new Size(45, 45));
                case Class.Rogue:       return new Bitmap(Resources.Rogue,       new Size(45, 45));
                case Class.Priest:      return new Bitmap(Resources.Priest,      new Size(45, 45));
                case Class.DeathKnight: return new Bitmap(Resources.DeathKnight, new Size(45, 45));
                case Class.Shaman:      return new Bitmap(Resources.Shaman,      new Size(45, 45));
                case Class.Mage:        return new Bitmap(Resources.Mage,        new Size(45, 45));
                case Class.Warlock:     return new Bitmap(Resources.Warlock,     new Size(45, 45));
                case Class.Druid:       return new Bitmap(Resources.Druid,       new Size(45, 45));
            }
            return Resources.Priest;
        }

        protected override string GetDescription(CGUnit_C model)
        {
            if (model.Type == ObjectType.Player)
                return $"Level {model.UNIT_FIELD_LEVEL} {model.Gender} {model.Race} {model.Class}";
            return $"Level {model.UNIT_FIELD_LEVEL} {model.Gender} {model.Class}";
        }
    }
}

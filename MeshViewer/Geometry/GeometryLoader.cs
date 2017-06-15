﻿using MeshViewer.Geometry.Map;
using MeshViewer.Geometry.Vmap;
using MeshViewer.Rendering;

namespace MeshViewer.Geometry
{
    public sealed class GeometryLoader
    {
        private VMapLoader VMAP { get; set; }
        private MapLoader MAP { get; set; }

        public string Directory { get; set; }
        public int MapID
        {
            set
            {
                MAP = null;
                MAP = new MapLoader(Directory, value);

                VMAP = null;
                VMAP = new VMapLoader(Directory, value);
            }
        }

        public GeometryLoader(string directory, int mapID)
        {
            Directory = directory;

            VMAP = new VMapLoader(Directory, mapID);
            MAP = new MapLoader(Directory, mapID);
        }

        public void LoadTile(int tileX, int tileY)
        {
            MAP.LoadTile(tileX, tileY);
            VMAP.LoadTile(tileX, tileY);
        }

        public void Render(int centerTileX, int centerTileY, Camera camera)
        {
            MAP.Render(centerTileX, centerTileY, camera);
            VMAP.Render(centerTileX, centerTileY, camera);
        }
    }
}

// MapLoader.cs

using System;
using System.Collections.Generic;

namespace MapLoading
{
    public class MapLoader
    {
        // Method to load a map from file
        public void LoadMap(string path)
        {
            // Load map data from the specified path
            Console.WriteLine($"Loading map from {path}...");
            // Add custom map loading logic here
        }

        // Method to list available maps
        public List<string> ListAvailableMaps()
        {
            Console.WriteLine("Listing available maps...");
            // Return list of available maps (mock data for now)
            return new List<string> { "Map1", "Map2", "Map3" };
        }
    }
}
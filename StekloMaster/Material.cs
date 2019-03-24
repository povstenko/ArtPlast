using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StekloMaster
{
    class Material
    {
        private int id;
        public int Id
        {
            get { return id; }
        }

        private string category;
        public string Category
        {
            get { return category; }
        }

        private string name;
        public string Name
        {
            get { return name; }
        }


        private string color;
        public string Color
        {
            get { return color; }
        }

        private int cost;
        public int CostPerMeter
        {
            get { return cost; }
        }

        private string description;
        public string Description
        {
            get { return description; }
        }

        public Material()
        {
                
        }
        public Material(int id, string category, string name, string color, int cost, string description)
        {
            this.id = id;
            this.category = category;
            this.name = name;
            this.color = color;
            this.cost = cost;
            this.description = description;
        }
        
        public override string ToString()
        {
            return $"{id} | {category} | {name} | {color} | {cost}";
        }
    }
}
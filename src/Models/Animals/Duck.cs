using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Duck : IResource, IEggProducing, IFeatherProducing
    {
        private Guid _id = Guid.NewGuid();

        public int EggsProduced { get; } = 6;

        private double _feathersProduced = 0.75;

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        public double GrassPerDay { get; set; } = 0.8;


        public string Type { get; } = "Duck";


        public int Gather()
        {
            return EggsProduced;
        }

        double IFeatherProducing.Pluck()
        {
            return 0.75;
        }

        public override string ToString()
        {
            return "The Duck goes Quack!";
        }
    }
}
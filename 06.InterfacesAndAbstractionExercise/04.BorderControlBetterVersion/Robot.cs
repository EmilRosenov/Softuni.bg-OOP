using System;
using System.Collections.Generic;
using System.Text;

namespace _04.BorderControlBetterVersion
{
    public class Robot : IIdentifiable
    {
        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }

        public string Model { get; set; }
        public string Id { get; }
    }
}

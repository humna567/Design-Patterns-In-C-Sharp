using System;

namespace DesignPatterns
{
    public class utensils
    {
        public string Kitchen { get; set; }
        public string Room { get; set; }
        public string Garage { get; set; }
    }

    public class softwarehouse
    {
        private utensils _utensils = new utensils();

        public void SetKitchen(string kitchen)
        {
            _utensils.Kitchen = kitchen;
        }

        public void SetRoom(string room)
        {
            _utensils.Room = room;
        }

        public void SetGarage(string garage)
        {
            _utensils.Garage = garage;
        }

        public utensils Build()
        {
            return _utensils;
        }
    }

    public class softwarehouse1
    {
        private utensils _utensils = new utensils();

        public void SetKitchen(string kitchen)
        {
            _utensils.Kitchen = kitchen;
        }

        public void SetRoom(string room)
        {
            _utensils.Room = room;
        }

        public void SetGarage(string garage)
        {
            _utensils.Garage = garage;
        }

        public utensils Build()
        {
            return _utensils;
        }
    }

    public class thing
    {
        public utensils BuildUtensils(softwarehouse1 Builder)
        {
            utensils things = new utensils();

            Builder.SetKitchen("KITCHEN1");
            Builder.SetGarage("garage1");
            Builder.SetRoom("Room1");

            return Builder.Build();
        }
    }
}

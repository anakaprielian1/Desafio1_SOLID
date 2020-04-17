//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        // se calcula el costo por step ya que esta clase tiene la informacion necesaria para esto
        // con esto se cumple con el principio de experto
        public double StepCost
        {
            get
            {
                return (this.Quantity * this.Input.UnitCost / 1000) + (this.Time * this.Equipment.HourlyCost / (60 * 60));
            }
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }
    }
}
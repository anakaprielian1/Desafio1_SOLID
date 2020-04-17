//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        // esta clase tiene la informacion de todos los pasos (steps) de la receta
        // a su vez se conoce el costo asociado a cada paso (metodo de la clase Step)
        // Por tanto en esta clase se calcula el costo total de la receta y se imprime la misma.
        // De esta forma se cumple con el principio de experto.
        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
            Console.WriteLine($"Total: {this.GetProductionCost}");
        }

        public double GetProductionCost
        {
            get
            {
                double result = 0;
                foreach (Step item in this.steps)
                {
                    result = result + item.StepCost;
                    result = Math.Round(result, 0);
                }
                return result;
            }
        }
    }
}
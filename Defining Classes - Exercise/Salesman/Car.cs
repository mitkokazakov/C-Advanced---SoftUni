

using System.Text;

namespace Salesman
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int? Weight { get; set; }
        public string Color { get; set; }

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }

        public Car(string model, Engine engine, int weight) : this(model,engine)
        {
            this.Weight = weight;
        }

        public Car(string model, Engine engine, string color) : this(model,engine)
        {
            this.Color = color;
        }

        public Car(string model, Engine engine, int weight, string color) : this(model, engine)
        {
            this.Weight = weight;
            this.Color = color;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            string strWeight = this.Weight.HasValue ? this.Weight.ToString() : "n/a";
            string strColor = string.IsNullOrEmpty(this.Color) ? "n/a" : this.Color;

            sb.AppendLine($"{this.Model}:").
                Append($"{this.Engine}").
                AppendLine($" Weight: {strWeight}").
                Append($" Color: {strColor}");
            return sb.ToString();
        }
    }
}

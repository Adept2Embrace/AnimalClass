namespace AnimalClass
{
    public class Animal
    {
        
        public int Age { get; set; }
        
        public Animal(int age)
        {
            this.Age = age;
        }

        public virtual bool isBaby()
        {
            return this.Age < 1;            
        }
    }

    public class Dogs : Animal
    {
        public string Color { get; set; }

        public Dogs(int age, string color) : base(age) // creating constructor for child class Dogs
        {
            this.Color = color;
        }

        public override bool isBaby()// overided function from parent class
        {
            return this.Age < 2;
        }
    }
}

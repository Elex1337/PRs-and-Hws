using System;

class Car
{
    private string name; //Марка авто
    private string model; //Модель авто
    private int year; //год выпуска авто
    private double enginesize;// обьем авто
    private bool isAuto;//Являеться ли автоматической коробкой
    //Статистические поля   
    private static int totalCars = 0;
    private static double price = 1000;
    /*public string Name { get => name; set => name = value; }
    public string Model { get => model; set => model = value; }
    public int Year { get => year; set => year = value; }
    public double EngineSize { get => enginesize; set => enginesize = value; }
    public bool IsAutomatic { get => isAuto; set => isAuto = value; }Z*/
    //не знаю что было бы лучше вот так или иначе


    //конструктор по умол
    public Car()
    {
        name = "Toyota";
        model = "70";
        year = 2020;
        enginesize = 3.5;
        isAuto = true;

    }
    //статик конструктро
    static Car()
    { 
        totalCars = 15;
    }
        
    //надеюсь хватит одного перегруженного конструктора

    public Car(string name, string model, int year, double enginesize,bool isAuto)
    
    {
        this.name = name;
        this.model = model;
        this.year = year;
        this.enginesize = enginesize;
        this.isAuto = isAuto;
    }
    public string GetName()
    {
        return name;
    }
    public string GetModel()
    {
        return model;
    }
    public int GetYear()
    {
        return year;
    }public double GetSize()
    {
        return enginesize;
    }
    public bool GetAutomatic()
    {
        return isAuto;
    }
    public void SetName(string name)
    {
        this.name = name;
    }
    public void SetModel(string model)
    {
        this.model = model;
    }
    public void SetYear(int year)
    {
        this.year = year;
    }
    public void SetSize(double enginesize)
    {
        this.enginesize = enginesize;
    }
    public void SetAutomatic(bool isAuto)
    {
        this.isAuto = isAuto;
    }
    //Метод принимающий аргументы по ссылке
    public void UpdateModel(ref string newModel)
    {
        model = newModel;
    }
    public static int TotalCars
    {
        get { return totalCars; }
    }
    public static double Price
    {
        get { return price; }
        set { price = value; }
    }

}

class Program
{
    public static void Main()
    {
        Car[] cars = new Car[5];
        cars[0] = new Car("Toyta", "Camry", 2020, 3.5, true);
        cars[1] = new Car("Toyta", "Camry", 2020, 3.5, true);
        cars[2] = new Car("Toyta", "Camry", 2020, 3.5, true);
        cars[3] = new Car("Toyta", "Camry", 2020, 3.5, true);
        cars[4] = new Car("Toyta", "Camry", 2020, 3.5, true);
        
        foreach (var car in cars)
        {
            Console.WriteLine($"Марка: {car.GetName()}, Модель: {car.GetModel()}, Год: {car.GetYear()}, Объем: {car.GetSize()}, Автоматическая: {car.GetAutomatic()}");
        }

        Console.WriteLine($"Общее количество машин: {Car.TotalCars}");
    }
}

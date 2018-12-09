using Patterns.Adapter.Classes;
using Patterns.Command.Classes;
using Patterns.Decorator;
using Patterns.Facade;
using Patterns.Factory;
using Patterns.Iterator.Classes;
using Patterns.Iterator.Interfaces;
using Patterns.Observer.Classes;
using Patterns.Observer.Interfaces;
using Patterns.SingletonPattern;
using Patterns.StatePattern.Classes;
using Patterns.Strategy;
using Patterns.Strategy.Interfaces;
using Patterns.TemplatePattern;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Decorator();
            Console.WriteLine("_______________");
            Strategy();
            Console.WriteLine("_______________");
            Factory();
            Console.WriteLine("_______________");
            Singleton();
            Console.WriteLine("_______________");
            Adapter();
            Console.WriteLine("_______________");
            Observer();
            Console.WriteLine("_______________");
            Facade();
            Console.WriteLine("_______________");
            Template();
            Console.WriteLine("_______________");
            Command();
            Console.WriteLine("_______________");
            Iterator();
            Console.WriteLine("_______________");
            State();
        }
        static void Decorator()
        {
            Beverage beverage1 = new Espresso();
            Console.WriteLine(beverage1.GetDescription());
            Console.WriteLine(beverage1.GetCost());

            Beverage beverage2 = new Espresso();
            beverage2 = new Mocha(beverage2);
            Console.WriteLine(beverage2.GetDescription());
            Console.WriteLine(beverage2.GetCost());

            Beverage beverage3 = new Espresso();
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.GetDescription());
            Console.WriteLine(beverage3.GetCost());
        }
        static void Strategy()
        {
            Strategy.Duck aliveDuck = new AliveDuck();
            aliveDuck.PerformFly();
            Console.WriteLine();
            aliveDuck.setFlyBehavior(new FlyNorth());
            aliveDuck.PerformFly();
            Console.WriteLine();
            aliveDuck.setFlyBehavior(new FlySouth());
            aliveDuck.PerformFly();
            Console.WriteLine();
            aliveDuck.setFlyBehavior(new FlyWithWings());
            aliveDuck.PerformFly();
        }
        static void Factory()
        {
            FactoryPizza facPizza = new FactoryPizza();
            facPizza.createPizza("cheese").Prepare();
            facPizza.createPizza("cheese").Bake();
            facPizza.createPizza("cheese").Cut();
            facPizza.createPizza("cheese").Box();
        }
        public static void Singleton()
        {
            Singleton singleton = SingletonPattern.Singleton.GetInstance("Frank");
            Console.WriteLine(singleton.GetName);

            singleton = SingletonPattern.Singleton.GetInstance("Steven");
            Console.WriteLine(singleton.GetName);
        }
        static void Adapter()
        {
            Console.WriteLine("Duck:");
            Adapter.Classes.Duck duck = new Adapter.Classes.Duck();
            duck.Quack();
            duck.Fly();
            Console.WriteLine();

            Console.WriteLine("Turkey:");
            Turkey turkey = new Turkey();
            turkey.Gobble();
            turkey.Fly();
            Console.WriteLine();

            Console.WriteLine("DuckAdapter:");
            DuckAdapter duckAdapter = new DuckAdapter(turkey);
            duckAdapter.Quack();
            duckAdapter.Fly();
        }
        static void Observer()
        {
            var observable = new ObservableSubject();
            IObserver obsMicrosoft = new ObserverMicrosoft(observable);
            IObserver obsAmazon = new ObserverAmazon(observable);

            observable.SendMessage("Mark", "Hello World");
            observable.SendMessage("Larry", "Hello World");
        }
        static void Facade()
        {
            Screen screen = new Screen();
            Tuner tuner = new Tuner();
            DVDPlayer dvdplayer = new DVDPlayer();
            Popcorn popcorn = new Popcorn();
            Amplifier amp = new Amplifier();
            HomeTheaterFacade facade = new HomeTheaterFacade(screen, tuner, dvdplayer, popcorn, amp);
            facade.WatchMovie();
            Console.WriteLine();
            facade.EndMovie();
        }
        static void Template()
        {
            Console.WriteLine("Prepare tea");
            Tea tea = new Tea();
            tea.PrepareRecipe();
            Console.WriteLine();
            Console.WriteLine("Prepare coffee");
            Coffee coffee = new Coffee();
            coffee.PrepareRecipe();
        }
        static void Command()
        {
            SimpleRemoteControl remote = new SimpleRemoteControl();
            remote.SetCommand(new LightOnCommand(new Light()));
            remote.ButtonWasPressed();
            remote.SetCommand(new StereoCommand(new Stereo()));
            remote.ButtonWasPressed();
        }
        static void Iterator()
        {
            IMenu pancakeHouseMenu = new PancakeHouseMenu();
            IMenu dinnerMenu = new DinnerMenu();
            Waitress waitress = new Waitress(pancakeHouseMenu, dinnerMenu);
            waitress.PrintMenu();
        }
        static void State()
        {
            GumballMachine gumballMachine = new GumballMachine(100, "Seattle");
            GumballMonitor gumballMonitor = new GumballMonitor(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMonitor.Report();
        }
    }
}

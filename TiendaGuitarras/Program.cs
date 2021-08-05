using abstractFactory;
using DecoratorPattern;
using DecoratorPattern.baseBeverage;
using DecoratorPattern.Condiments;

using LocationObserver;
using ObserverNet;
using SingletonPattern;
using System;
using System.Collections.Generic;
using System.Threading;

namespace TiendaGuitarras
{

    class Program
    {
        
        
        static void Main(string[] args)
        {
            //PizzaStore nyPizzaStore = new NYPizzaStore();
            ////PizzaStore chicagoPizza = new ChicagoPizzaStore();
            //nyPizzaStore.orderPizza("cheese");
            ////chicagoPizza.orderPizza("clam");
            ///
            



            

            


            Thread t1 = new Thread(new ThreadStart(procesoChocolate1));
            Thread t2 = new Thread(new ThreadStart(procesoChocolate2));
            t1.Start();
            t2.Start();

            //Beverage beverage = new Espresso();

            //Console.WriteLine(beverage.GetDescription() + " $" + beverage.cost());

            //Beverage beverage2 = new DarkRoast();

            //beverage2 = new Mocha(beverage2);
            //Console.WriteLine(beverage2.GetDescription() + " $" + beverage2.cost());
            //beverage2 = new Mocha(beverage2);
            //Console.WriteLine(beverage2.GetDescription() + " $" + beverage2.cost());
            //beverage2 = new Whip(beverage2);
            //Console.WriteLine(beverage2.GetDescription() + " $"+ beverage2.cost());

            //Beverage beverage3 = new HouseBlend();
            //beverage3 = new Soy(beverage3);
            //beverage3 = new Mocha(beverage3);
            //beverage3 = new Whip(beverage3);

            //Console.WriteLine(beverage3.GetDescription() + " $" + beverage3.cost());

            //WeatherDataSubject weatherProvider = new WeatherDataSubject();
            //CurrentConditionDisplay currentCondition = new CurrentConditionDisplay("Curren condition Display");
            //ForecastDisplay forecast = new ForecastDisplay("Forecast Display");
            //StaticDisplay display = new StaticDisplay("Avg/Max/Min temperature Display = ");
            //HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay("Heat index is");

            //forecast.Subscribe(weatherProvider);
            //display.Subscribe(weatherProvider);
            //currentCondition.Subscribe(weatherProvider);
            //heatIndexDisplay.Subscribe(weatherProvider);



            //weatherProvider.TrackMeasurements(new Weather(80, 65, 30.4f));
            //weatherProvider.TrackMeasurements(new Weather(83, 70, 29.4f));
            //weatherProvider.TrackMeasurements(new Weather(78, 90, 15.4f));

            //forecast.Unsubscribe();
            //weatherProvider.TrackMeasurements(new Weather(62, 90, 28.1f));
            //weatherProvider.EndTransmission();


            //LocationTrackerSubject provider = new LocationTrackerSubject();
            //LocationReporterObserver reporter1 = new LocationReporterObserver("FixedGPS");
            //reporter1.Subscribe(provider);
            //LocationReporterObserver reporter2 = new LocationReporterObserver("MobileGPS");
            //reporter2.Subscribe(provider);

            //provider.TrackLocation(new Location(47.6456, -122.1312));
            //reporter1.Unsubscribe();
            //provider.TrackLocation(new Location(47.6677, -122.1199));
            //provider.TrackLocation(null);
            //provider.EndTransmission();


            //WeatherData weatherData = new WeatherData();

            //CurrentConditionDisplay currentCondition = new CurrentConditionDisplay(weatherData);
            //StaticsDisplay staticsDisplay = new StaticsDisplay(weatherData);
            //ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            //weatherData.setMeasurements(80, 65, 30.4f);
            //weatherData.setMeasurements(83, 70, 29.4f);
            //weatherData.setMeasurements(78, 90, 15.4f);

            //weatherData.removeObserver(forecastDisplay);
            //weatherData.setMeasurements(62, 90, 28.1f);





            //Inventario inventory = new Inventario();
            //initializeInventory(inventory);

            //GuitarSpec whatErinLikes =
            //          new GuitarSpec(Builder.FENDER, "Stratocastor",
            //         Tipe.ELECTRIC, Wood.ALDER, Wood.ALDER);

            //List<GuitarSpec> matchingGuitars = inventory.search(whatErinLikes);
            //if(matchingGuitars.Count != 0)
            //{
            //    Console.WriteLine("Erin, you might like these guitars:");

            //    foreach (var item in matchingGuitars)
            //    {


            //        Console.WriteLine("  We have a " +
            //                              item._builder + " " + item._model + " " +
            //                              item._type + " guitar:\n     " +
            //                              item._backWood+ " back and sides,\n     " +
            //                              item._topWood + " top.\n  !\n  ----");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No hay recomendaciones");
            //}

        }


        private static void procesoChocolate1()
        {
            ChocolateBoiler boiler = ChocolateBoiler.GetChocolateBoiler();
            boiler.fill();            
            boiler.boild();
            boiler.drain();
        }

        private static void procesoChocolate2()
        {
            ChocolateBoiler boiler = ChocolateBoiler.GetChocolateBoiler();
            boiler.fill();            
            boiler.boild();
            boiler.drain();
        }

        private static void initializeInventory(Inventario inventory)
        {
            inventory.addGuitar("11277", 3999.95, Builder.COLLINGS,
                    "CJ", Tipe.ACOUSTIC,
                    Wood.INDIAN_ROSEWOOD, Wood.SITKA);
            inventory.addGuitar("V95693", 1499.95, Builder.FENDER,
                                "Stratocastor", Tipe.ELECTRIC,
                                Wood.ALDER, Wood.ALDER);
            inventory.addGuitar("V9512", 1549.95, Builder.FENDER,
                                "Stratocastor", Tipe.ELECTRIC,
                                Wood.ALDER, Wood.ALDER);
            inventory.addGuitar("122784", 5495.95, Builder.MARTIN,
                                "D-18", Tipe.ACOUSTIC,
                                Wood.MAHOGANY, Wood.ADIRONDACK);
            inventory.addGuitar("76531", 6295.95, Builder.MARTIN,
                                "OM-28", Tipe.ACOUSTIC,
                                Wood.BRAZILIAN_ROSEWOOD, Wood.ADIRONDACK);
            inventory.addGuitar("70108276", 2295.95, Builder.GIBSON,
                                "Les Paul", Tipe.ELECTRIC,
                                Wood.MAHOGANY, Wood.MAHOGANY);
            inventory.addGuitar("82765501", 1890.95, Builder.GIBSON,
                                "SG '61 Reissue", Tipe.ELECTRIC,
                                Wood.MAHOGANY, Wood.MAHOGANY);
            inventory.addGuitar("77023", 6275.95, Builder.MARTIN,
                                "D-28", Tipe.ACOUSTIC,
                                Wood.BRAZILIAN_ROSEWOOD, Wood.ADIRONDACK);
            inventory.addGuitar("1092", 12995.95, Builder.OLSON,
                                "SJ", Tipe.ACOUSTIC,
                                Wood.INDIAN_ROSEWOOD, Wood.CEDAR);
            inventory.addGuitar("566-62", 8999.95, Builder.RYAN,
                                "Cathedral", Tipe.ACOUSTIC,
                                Wood.COCOBOLO, Wood.CEDAR);
            inventory.addGuitar("6 29584", 2100.95, Builder.PRS,
                                "Dave Navarro Signature", Tipe.ELECTRIC,
                                Wood.MAHOGANY, Wood.MAPLE);
        }

    }
}

# MapMarkers
POC - To demonstrate how to swap data repositories using DI

## Some notes
Built with Visual Studio 2019
ASP.NET MVC Framework 4.7.2

A quick example of how to use Dependency Injection with the generic Repository Pattern,
to show how you can easily swap out different datasources to display google marker pins on a map based on a set of geocordinates.

## How
~~~c#
 public class DefaultRegistry : Registry {
    public DefaultRegistry() {
    ...
      For<IRepository<Location>>().Use<XmlRepository<Location>>();
     // For<IRepository<Location>>().Use<JsonRepository<Location>>();
     ...
     }
  }
~~~

By swapping these two lines out, you are effectively swapping out the data source of the Map markers (/App_Data/Locations.xml to /App_Data/Locations.json  ),
without having to change any other part of the system.

##
Next steps
Write an Entity Framework Database Context , so that the data can be fetched from a SQL database. 
Once again,  once configured all you should have to do is swap out the repository in the DefaultRegistry and existing parts of the system should remain as is.

selfRefModel
============

In EF i need to describe the following relationship:

a company may have many Locations, like

    headquarter         <= main location 
              plant      ----+
              warehouse      |
              store-1        +----> child Locations
              store-2        |
              store-n    ----+

So I need a mainLocationID in the Location model, so that I can 

  1) given the main location I can access all its child locations

    Location myTopLocation = db.Locations.Find(an_id_of_some_top_location);
    ICollection<Location> myChildLocations = myTopLocation.ChildLocations

  2) given a child location I can find its main location.

    Location myChildLocation = db.Locations.Find(an_id:_of_some_child_location);
    Location myTopLocation = myChildLocation.topLocation;


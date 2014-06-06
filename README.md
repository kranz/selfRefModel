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

  2) given a child location I can find its main location.

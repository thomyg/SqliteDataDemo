# SqliteDataDemo

Simple project using C# Source Generatos to create partial classes, razor pages and css files based on an EF core data class. 

## Simple path to awesomness
- clone project
- create a data class 
- add a DbSet to the db context class and annotate it with "GenerateUI"
- Rebuild the generator project
- Rebuild the consuming project

### Expected behavior

Source generator should create the following:
- a partial class including the db service part
- a custom EventArgs class for the UI
- razor pages for the page, grid and form component
- razor component for the nav menu + css

# DISCLAIMER - DO NOT USE THIS IN PRODUCTION

I'm "playing" here with things. Please don't take that as a blueprint for your work! 

Check out this [twitter thread](https://twitter.com/jaredpar/status/1483260034624606208?s=20) to hear the opinion on the approach from people creating that technology. The thread disucusses IO impacts if creating non .cs files. You could work around that with a simple check to minimize the impact, but again, do not use that in production!




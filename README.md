# entity-framework-automapper
Sample EF core Automapper

PM> Install-Package AutoMapper

Add MappingProfile class inherintance Profile

Prodgram.cs
// Auto Mapper Configurations
 var mapperConfig = new MapperConfiguration(mc =>
 {
     mc.AddProfile(new MappingProfile());
 });

 IMapper mapper = mapperConfig.CreateMapper();
 services.AddSingleton(mapper);


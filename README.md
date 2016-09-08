# telerik-aspnet-mvc-grid-diffviewmodel 

This is a sample of using Telerik's ASP.NET MVC Grid with one entity model and multiple view models.

We use only one entity type: TestEntity. TestEntity has a Type property, we use different view models on different type. There are four types in this sample:  EntityType.A, EntityType.B, EntityType.C, EntityType.D. So there are four view models: TestEntityViewModelA, TestEntityViewModelB, TestEntityViewModelC, TestEntityViewModelD.

This sample create a controller "TestEntitiesController" and "Index" view, the view contains four tabs which contains a grid for a certain type of view model.

The sample will handle custom filter implementation with adding filtering TestEntity's Type property, change the filtering property name for custom purposes. Please check TestEntitiesController.cs.  

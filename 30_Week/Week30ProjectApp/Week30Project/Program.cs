using DemoLibrary.Models;

List<(PersonModel, VehicleModel)> lst = new List<(PersonModel, VehicleModel)>
{
    (new PersonModel { FirstName = "Marc", LastName = "Moxey" },
    new VehicleModel { Make = "Toyota", Model = "Gr86", Year = 2023 }),

    (new PersonModel { FirstName = "Andre", LastName = "Newton" },
    new VehicleModel { Make = "Toyota", Model = "GrSupra", Year = 2025 }),

    (new PersonModel { FirstName = "Deshawn", LastName = "Newton" },
    new VehicleModel { Make = "Nissan", Model = "400z", Year = 2024 })
};




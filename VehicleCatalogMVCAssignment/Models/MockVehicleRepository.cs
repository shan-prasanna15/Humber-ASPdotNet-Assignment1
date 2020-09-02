using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleCatalogMVCAssignment.Models
{
    public class MockVehicleRepository : IVehicleRepository
    {
        private readonly IVehicleCategoryRepository _repo;

        public MockVehicleRepository(IVehicleCategoryRepository repo)            
        {
            _repo = repo;
        }
        public IEnumerable<Vehicle> GetAllVehicles => new List<Vehicle>
        {
            new Vehicle{VinNo = 32136, Brand = "Volvo" , Model = "V70", ModelYear = 2007, IsAutomaticTransmission  = true,
                VehicleClass = _repo.GetAllCategories.ToList()[2],
                ImageUrl = "https://pictures.topspeed.com/IMG/crop_webp/200701/2007-volvo-v70-special-ed-2_800x0.webp"},
            new Vehicle{VinNo = 13156, Brand = "BMW" , Model = "535d", ModelYear = 2010, IsAutomaticTransmission  = false,
                VehicleClass = _repo.GetAllCategories.ToList()[2],
                ImageUrl = "https://thumbor.forbes.com/thumbor/960x0/https%3A%2F%2Fblogs-images.forbes.com%2Fnargessbanks%2Ffiles%2F2017%2F08%2F3.-BMW-5-Series-Touring-1200x800.jpg"},
            new Vehicle{VinNo = 13156, Brand = "Jaguar" , Model = "XJ", ModelYear = 2012, IsAutomaticTransmission  = true,
                VehicleClass = _repo.GetAllCategories.ToList()[1],
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d3/Jaguar_XJ_vs._Jetman_-_World-First_Desert_Drag_Race_%2822928441043%29_%28cropped%29.jpg/1920px-Jaguar_XJ_vs._Jetman_-_World-First_Desert_Drag_Race_%2822928441043%29_%28cropped%29.jpg"},
            new Vehicle{VinNo = 13156, Brand = "Saab" , Model = "9-2x Aero", ModelYear = 2005, IsAutomaticTransmission  = false,
                VehicleClass = _repo.GetAllCategories.ToList()[3],
                ImageUrl = "https://hips.hearstapps.com/hmg-prod/amv-prod-cad-assets/images/04q3/267352/2005-saab-9-2x-aero-photo-5449-s-original.jpg?crop=1.00xw:1.00xh;0,0&resize=768:*"},
            new Vehicle{VinNo = 56154, Brand = "Lexus" , Model = "GX470", ModelYear = 2009, IsAutomaticTransmission  = true,
                VehicleClass = _repo.GetAllCategories.ToList()[0],
                ImageUrl= "https://m.media-amazon.com/images/I/71bayHRBehL._UY560_.jpg"},
            new Vehicle{VinNo = 58954, Brand = "LandRover" , Model = "Defender", ModelYear = 2015, IsAutomaticTransmission  = true,
                VehicleClass = _repo.GetAllCategories.ToList()[0],
                ImageUrl = "https://s.aolcdn.com/dims-global/dims3/GLOB/legacy_thumbnail/1049x590/quality/80/https://s.aolcdn.com/os/ab/_cms/2020/05/05063544/land-rover-defender-james-bond-spectre-auction-16.jpg"}
        };

        public IEnumerable<Vehicle> ManualTransmissionVehicles { get; }        

        public Vehicle GetVehicleByVinNo(int VinNo)
        {
            return GetAllVehicles.FirstOrDefault(v => v.VinNo == VinNo);
        }
    }
}

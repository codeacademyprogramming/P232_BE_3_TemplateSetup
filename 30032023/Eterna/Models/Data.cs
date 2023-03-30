using System.Collections.Generic;

namespace Eterna.Models
{
    public static class Data
    {
        public static List<Service> Services = new List<Service>
            {
                new Service{Id=1, Title="Keyfiyyetli xidmet",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi",Icon="<i class=\"bx bxl-dribbble\"></i>"},
                new Service{Id=2, Title="Keyfiyyetsiz xidmet",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi",Icon="<i class=\"bx bxl-dribbble\"></i>"},
                new Service{Id=3, Title="Keyfiyyetle xidmet",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi",Icon="<i class=\"bx bxl-dribbble\"></i>"},
                new Service{Id=4, Title="Keyfiyyetde xidmet",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi",Icon="<i class=\"bx bxl-dribbble\"></i>"},
                new Service{Id=5, Title="Keyfiyyetden xidmet",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi",Icon="<i class=\"bx bxl-dribbble\"></i>"},
                new Service{Id=6, Title="Keyfiyyete xidmet",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi",Icon="<i class=\"bx bxl-dribbble\"></i>"},
            };

        public static List<Slider> Sliders = new List<Slider>
            {
                new Slider{Id =1,Title1="Welcome to",Title2="Code",BtnText="Read More",BgImage="slide-1.jpg",BtnUrl="https://github.com",  Desc="Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil",},
                new Slider{Id =2,Title1="Salam to",Title2="Code",BtnText="Read More",BgImage="slide-2.jpg",BtnUrl="https://github.com",  Desc="Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil",},
                new Slider{Id =3,Title1="Sag ol to",Title2="Code",BtnText="Read More",BgImage="slide-3.jpg",BtnUrl="https://github.com",  Desc="Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil",},
                new Slider{Id =4,Title1="Xosgeldiniz to",Title2="Code",BtnText="Read More",BgImage="slide-2.jpg",BtnUrl="https://github.com",  Desc="Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil",},
            };
    }
}

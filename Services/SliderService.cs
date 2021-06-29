using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SliderService
    {
        private WebsuperContext _context;
        public SliderService(WebsuperContext context)
        {
            _context = context;
        }

        public List<Slider> GetSliders()
        {
            var sliders = _context.Sliders.ToList();

            return sliders;
        }
    }
}

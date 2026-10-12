using WebApplication1_vs2026_2.Model;

namespace WebApplication1_vs2026_2.Repository
{
    public class RepositoryIEM
    {

        public List<IEM> ListIEM = new List<IEM>
        {
            new IEM { idIEM = 1, IEMPercentage = 0.05f, MaxfiscalHorsepower = 100, MinfiscalHorsepower = 0 },
            new IEM { idIEM = 2, IEMPercentage = 0.10f, MaxfiscalHorsepower = 150, MinfiscalHorsepower = 101 },
            new IEM { idIEM = 3, IEMPercentage = 0.15f, MaxfiscalHorsepower = 200, MinfiscalHorsepower = 151 },
            new IEM { idIEM = 4, IEMPercentage = 0.20f, MaxfiscalHorsepower = 250, MinfiscalHorsepower = 201 },
            new IEM { idIEM = 5, IEMPercentage = 0.25f, MaxfiscalHorsepower = 3000, MinfiscalHorsepower = 251 }
        };

        public IEM GetIEMById(int id)
        {
            var iem = ListIEM.FirstOrDefault(i => i.idIEM == id);
            if (iem != null)
            {
                return iem;
            }
            else
            {
                return new IEM { idIEM = 0, IEMPercentage = 0.0f, MaxfiscalHorsepower = 0, MinfiscalHorsepower = 0 }; // Return a default IEM object if not found
            }
        }

        public List<IEM> GetAllIEM()
        {
            return ListIEM;

        }

        public float GetIEMByHorsepower(int horsepower)
        {
            var iem = ListIEM.FirstOrDefault(i => horsepower >= i.MinfiscalHorsepower && horsepower <= i.MaxfiscalHorsepower);
            if (iem != null)
            {
                return iem.IEMPercentage;
            }
            else
            {
                return 0; // Return a default IEM object if not found
            }
        }

    }
}

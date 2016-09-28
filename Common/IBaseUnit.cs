using System.Threading.Tasks;

namespace Interface
{
    public interface IBaseUnit
    {
        string Name { get ;  }

        Common.Tools.Coordinates CurrentPos { get; set; }

        Task<bool> Move(Common.Tools.Coordinates FinalPos );
    }
}
using System.Text;
using System.Threading.Tasks;
using GamerProject.Abstract;
using GamerProject.Entities;

namespace GamerProject.Entities
{
    public class Gamer : IEntity
    {

        public string GamerFirstName { get; set; }
        public string GamerLastName { get; set; }
        public string TcNo { get; set; }
    }
}
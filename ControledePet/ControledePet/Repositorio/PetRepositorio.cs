using ControledePet.Data;
using ControledePet.Models;
using ControledePet.Repositorio;

namespace ControledePet.PetRepositorio
{
    public class PetRepositorio: IPetRepositorio
    {
       private readonly BancoContext _bancoContext;
        public PetRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public PetModel Adicionar(PetModel pet)
        {
            _bancoContext.Pets.Add(pet);
            _bancoContext.SaveChanges();
            return pet;
        }
    }
}

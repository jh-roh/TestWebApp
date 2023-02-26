using System.Collections.Generic;

namespace TestWebApp.DotNetNote.Models
{
    public interface IVariableRepositoryInMemory
    {
        List<Variable> GetAll();
    }
}
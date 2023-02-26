using System.Collections.Generic;

namespace TestWebApp.DotNetNote.Models
{
    public class Variable
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public string Value { get; set; }
    }

    public class VariableRepositoryInMemory : IVariableRepositoryInMemory
    {
        public List<Variable> GetAll()
        {
            List<Variable> variables = new List<Variable>()
            {
                new Variable { Id = 1, Text = "한국어", Value = "KR" },
                new Variable { Id = 2, Text = "영어", Value = "EN" },
            };

            return variables;

        }
    }
}

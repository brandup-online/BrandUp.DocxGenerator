﻿using BrandUp.DocumentTemplater.Abstraction;
using BrandUp.DocumentTemplater.Handling;

namespace BrandUp.DocumentTemplater.Commands
{
    /// <summary>
    /// Задает свойство как контектст данных
    /// </summary>
    internal class SetPropertyContext : ITemplaterCommand
    {
        #region IContextCommand members

        public string Name => "setcontextofproperty";

        public HandleResult Execute(List<string> parameters, object dataContext)
        {
            object value = dataContext.GetType().GetValueFromContext(parameters[0], dataContext);

            return new(value);
        }

        #endregion
    }
}
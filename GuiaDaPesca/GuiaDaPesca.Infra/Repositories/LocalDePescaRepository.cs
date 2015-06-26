using GuiaDaPesca.Domain.Model;
using GuiaDaPesca.Infra.Context;
using GuiaDaPesca.Infra.Repositories;
using GuiaDePesca.Resourse.Exceptions;
using NHibernate;

using NHibernate.Transform;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GuiaDaPesca.Domain.Interfaces.Repositories
{
    public class LocalDePescaRepository : RepositoryBase<LocalDePesca>, ILocalDePescaContext
    {
    }
}

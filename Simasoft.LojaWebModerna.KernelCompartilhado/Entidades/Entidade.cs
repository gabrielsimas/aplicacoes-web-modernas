using System;
using Flunt.Notifications;

namespace Simasoft.LojaWebModerna.KernelCompartilhado
{
    public abstract class Entidade: Notifiable
    {
        protected Entidade()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
    }
}
using System;
namespace Exercicio_14.Entities.Exception {
    class WithDrawException : ApplicationException{
        public WithDrawException(string message)
        : base(message) {
        }
    }
}
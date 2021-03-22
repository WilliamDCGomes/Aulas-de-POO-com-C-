using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Resolvido_de_Conjuntos.Entities {
    class LogRecord {
        public string Username { get; set; }
        public DateTime Instant { get; set; }
        public int quantity = 1;

        public void Increment() {
            quantity++;
        }
        public override int GetHashCode() {
            return Username.GetHashCode();
        }
        public override bool Equals(object obj) {
            if(!(obj is LogRecord)) {
                return false;
            }
            LogRecord other = obj as LogRecord;
            return Username.Equals(other.Username);
        }
    }
}

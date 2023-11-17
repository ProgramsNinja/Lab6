﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб7
{
    public class MemoryRemoteControl:RemoteControl
    {
        private Dictionary<int, (int Power, int Mode)> dictionary = new Dictionary<int, (int Power, int Mode)>();

        public MemoryRemoteControl(IRemoteControl Remote) : base(Remote) { ArgumentNullException.ThrowIfNull( Remote); }

        public void Save(int index)
        {
            if (index <= 0)
            {
                throw new ArgumentException("index должен быть положительным числом", nameof(index));
            }

            dictionary[index] = (Power, Mode);
            Console.WriteLine("Сохраненный режим {0}: Мощность {1}, Режим {2}", index, Power, Mode);
        }

        public void Load(int index)
        {
            if (index <= 0)
            {
                throw new ArgumentException("index должен быть положительным числом", nameof(index));
            }

            if (dictionary.ContainsKey(index))
            {
                var d = dictionary[index];
                int savedPower = d.Power;
                int savedMode = d.Mode;

                Power = savedPower;
                Mode = savedMode;
                Remote.SetPower(Power);
                Remote.SetMode(Mode);
                Console.WriteLine("Загруженный режим {0}: Мощность {1}, Режим {2}", index, Power, Mode);
            }
            else
            {
                Console.WriteLine("Режим с индексом {0} не найден.", index);
            }
        }
    }
}

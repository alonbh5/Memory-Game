using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B20_Ex02
{
    class Player
    {
        string m_Name;
        bool m_Pc;
        int m_Pairs;
        internal AI m_PlayerVsComputer;        

        internal Player(string i_Name, bool i_Pc)
        {
            m_Name = i_Name;
            m_Pc = i_Pc;
            if (m_Pc)
            {
                m_PlayerVsComputer = new AI();
            }
        }

        internal string Name
        {
            get { return m_Name; }
        }

        internal int Pairs
        {
            get { return m_Pairs; }
            set { m_Pairs++; }
        }

        internal bool Pc
        {
            get { return m_Pc; }
        }
    }
}

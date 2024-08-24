﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NKit.Uart
{
    public class FuncCode16
    {
        public static byte[] BuildRtuRequest(int slaveAddress, int startHoldingRegisterAddress, short[] values)
        {
            if (slaveAddress < 0 || slaveAddress > 255)
            {
                throw new ArgumentOutOfRangeException("从机地址必须介于[0,255]");
            }

            return null;
        }
    }
}
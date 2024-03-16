using HidLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceSelector
{
    interface IDeviceGateway
    {
        List<Device> GetDevices();
    }
    
    interface IWindowGateway
    {
        List<Window> AllWindows();
    }
    
    internal class Window
    {
        public string name;
        public IntPtr handle;

        override public string ToString()
        {
            return name;
        }

        public Window(string name, IntPtr handle)
        {
            this.name = name;
            this.handle = handle;
        }
    }


    internal class Device
    {
        public string id;
        public string product;
        public string manufacturer;
        public string display;

        override public string ToString()
        {
            return display;
        }
        
        public Device(string id, string product, string manufacturer)
        {
            this.id = id;
            this.product = product;
            this.manufacturer = manufacturer;
            display = product + " [" + manufacturer + "]";
        }
    }
}

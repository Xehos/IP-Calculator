using System;
using System.Collections.Generic;
using System.Text;

namespace IP_Calculator
{
    class IP
    {
        private string ip;
        private int prefix;
        private string mask;
        private string broadcast;
        private string firstAssigned;
        private string lastAssigned;

        public string Ip { get => ip; set => ip = value; }
        public int Prefix { get => prefix; set => prefix = value; }
        public string Mask { get => mask; set => mask = value; }
        public string Broadcast { get => broadcast; set => broadcast = value; }
        public string FirstAssigned { get => firstAssigned; set => firstAssigned = value; }
        public string LastAssigned { get => lastAssigned; set => lastAssigned = value; }
        public IP(string ip, string prefix)
        {
            this.ip = ip;
            this.prefix = Convert.ToInt32(prefix.Replace("/",""));
        }

        public List<string> Ip_to_bin()
        {
            List<string> bin_ip = new List<string>();
            string[] oktety = this.ip.Split(".");
            foreach (string oktet in oktety)
            {
               
                string temp =  Convert.ToString(Convert.ToInt32(oktet), 2);
                string temp0s = "";
                for (int x = 0; x < (8 - temp.Length); x++)
                {
                    temp0s += 0;
                }
                temp = temp0s + temp;
                bin_ip.Add(temp);
   
                
            }
            return bin_ip;
        }

        public List<string> Prefix_to_sbntMask()
        {
            string mask = "";
            List<string> maskList = new List<string>();

            for(int x = 0; x < this.prefix; x++)
            {
                mask += "1";
            }
            for (int x = 0; x < 32-this.prefix; x++)
            {
                mask += "0";
            }
            string chunk = "";
            for (int x = 1; x <= 32; x++)
            {
                chunk += mask[x-1];
                if (x % 8 == 0)
                {
                    maskList.Add(chunk);
                    chunk = "";
                }
            }
            return maskList;
        }
        public List<string> Bin_to_ip(string bin)
        {
            List<string> str_ip = new List<string>();
            string chunk = "";
            bin = bin.Replace(".", "");
            for (int x = 1; x <= 32; x++)
            {
                chunk += bin[x - 1];
                if (x % 8 == 0)
                {
                    str_ip.Add(Convert.ToString(Convert.ToInt32(chunk,2)));
                    chunk = "";
                }
            }
            return str_ip;
        }
        public List<string> Get_network_address(List<string> ip, List<string> mask)
        {
            List<string> network_address = new List<string>();
            string chunk_ip;
            string chunk_mask;
            string chunk;
            for (int x=0; x < 4; x++)
            {
                chunk = "";
                chunk_ip = ip[x];
                chunk_mask = mask[x];
                for (int z = 0; z < 8; z++)
                {

                    if (chunk_ip[z] == '1' && chunk_mask[z] == '1')
                    {
                        chunk += 1;
                    }
                    else
                    {
                        chunk += 0;
                    }
                }

                network_address.Add(chunk);
            }
            return network_address;
        }
        public List<string> Get_broadcast_address(string ipbin)
        {
            List<string> broadcast_address = new List<string>();
            ipbin = ipbin.Replace(".", "");
            string ipbr = "";

            for(int x = 1; x <= 32; x++)
            { 
                if (x > this.prefix)
                {
                    ipbr += "1";
                }
                else
                {
                    ipbr += ipbin[x-1];
                }
                if (x % 8 == 0)
                {
                    broadcast_address.Add(ipbr);
                    ipbr = "";
                }
            }
            return broadcast_address;
        }
        public List<string> Get_first_assigned(string ipbin)
        {
            List<string> first_assigned = new List<string>();
            ipbin = ipbin.Replace(".", "");
            string firstassign = "";

            for(int x = 1; x <= 32; x++)
            {
                if (x > this.prefix && x != 32)
                {
                    firstassign += "0";
                }else if(x == 32)
                {
                    firstassign += "1";
                }
                else
                {
                    firstassign += ipbin[x-1];
                }
                if (x % 8 == 0)
                {
                    first_assigned.Add(firstassign);
                    firstassign = "";
                }

            }
            return first_assigned;
        }
        public List<string> Get_last_assigned(string ipbin)
        {
            List<string> last_assigned = new List<string>();
            ipbin = ipbin.Replace(".", "");
            string lastassign = "";

            for (int x = 1; x <= 32; x++)
            {
                if (x > this.prefix && x != 32)
                {
                    lastassign += "1";
                }
                else if (x == 32)
                {
                    lastassign += "0";
                }
                else
                {
                    lastassign += ipbin[x - 1];
                }
                
                if (x % 8 == 0)
                {
                    last_assigned.Add(lastassign);
                    lastassign = "";
                }

            }
            return last_assigned;
        }

        public int get_max_hosts() {
            int max = 0;
            return max;

        
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxide.Plugins
{
    [Info("NameColor", "aDrew1", "0.0.1")]
    public class NameColor : RustPlugin
    {
        [ChatCommand("color")]
        void ColorCommand (BasePlayer player, string command, string[] args)
        {
            String pName = player.UserIDString;


            if (args.Length == 0)
            {
                SendReply(player, "Not enough arguments");
            }
            else if (args.Length == 1)
            {
                // RED
                if (args[0] == "Red")
                {
                    SendReply(player, "Chat color set to RED");

                    rust.RunServerCommand("chat user add " + pName + " red");

                    rust.RunServerCommand("chat user remove " + pName + " blue");
                    rust.RunServerCommand("chat user remove " + pName + " green");
                    rust.RunServerCommand("chat user remove " + pName + " yellow");
                    rust.RunServerCommand("chat user remove " + pName + " orange");
                    rust.RunServerCommand("chat user remove " + pName + " pink");
                    rust.RunServerCommand("chat user remove " + pName + " white");
                    rust.RunServerCommand("chat user remove " + pName + " purple");

                    return;
                }
                if (args[0] == "red")
                {
                    SendReply(player, "Chat color set to RED");

                    rust.RunServerCommand("chat user add " + pName + " red");

                    rust.RunServerCommand("chat user remove " + pName + " blue");
                    rust.RunServerCommand("chat user remove " + pName + " green");
                    rust.RunServerCommand("chat user remove " + pName + " yellow");
                    rust.RunServerCommand("chat user remove " + pName + " orange");
                    rust.RunServerCommand("chat user remove " + pName + " pink");
                    rust.RunServerCommand("chat user remove " + pName + " white");
                    rust.RunServerCommand("chat user remove " + pName + " purple");

                    return;
                }
                // BLUE
                if (args[0] == "Blue")
                {
                    SendReply(player, "Chat color set to BLUE");

                    rust.RunServerCommand("chat user add " + pName + " blue");

                    rust.RunServerCommand("chat user remove " + pName + " red");
                    rust.RunServerCommand("chat user remove " + pName + " green");
                    rust.RunServerCommand("chat user remove " + pName + " yellow");
                    rust.RunServerCommand("chat user remove " + pName + " orange");
                    rust.RunServerCommand("chat user remove " + pName + " pink");
                    rust.RunServerCommand("chat user remove " + pName + " white");
                    rust.RunServerCommand("chat user remove " + pName + " purple");

                    return;
                }
                if (args[0] == "blue")
                {
                    SendReply(player, "Chat color set to BLUE");

                    rust.RunServerCommand("chat user add " + pName + " blue");

                    rust.RunServerCommand("chat user remove " + pName + " red");
                    rust.RunServerCommand("chat user remove " + pName + " green");
                    rust.RunServerCommand("chat user remove " + pName + " yellow");
                    rust.RunServerCommand("chat user remove " + pName + " orange");
                    rust.RunServerCommand("chat user remove " + pName + " pink");
                    rust.RunServerCommand("chat user remove " + pName + " white");
                    rust.RunServerCommand("chat user remove " + pName + " purple");

                    return;
                }
                // GREEN
                if (args[0] == "Green")
                {
                    SendReply(player, "Chat color set to GREEN");

                    rust.RunServerCommand("chat user add " + pName + " green");

                    rust.RunServerCommand("chat user remove " + pName + " red");
                    rust.RunServerCommand("chat user remove " + pName + " blue");
                    rust.RunServerCommand("chat user remove " + pName + " yellow");
                    rust.RunServerCommand("chat user remove " + pName + " orange");
                    rust.RunServerCommand("chat user remove " + pName + " pink");
                    rust.RunServerCommand("chat user remove " + pName + " white");
                    rust.RunServerCommand("chat user remove " + pName + " purple");

                    return;
                }
                if (args[0] == "green")
                {
                    SendReply(player, "Chat color set to GREEN");

                    rust.RunServerCommand("chat user add " + pName + " green");

                    rust.RunServerCommand("chat user remove " + pName + " red");
                    rust.RunServerCommand("chat user remove " + pName + " blue");
                    rust.RunServerCommand("chat user remove " + pName + " yellow");
                    rust.RunServerCommand("chat user remove " + pName + " orange");
                    rust.RunServerCommand("chat user remove " + pName + " pink");
                    rust.RunServerCommand("chat user remove " + pName + " white");
                    rust.RunServerCommand("chat user remove " + pName + " purple");

                    return;
                }
                // YELLOW
                if (args[0] == "Yellow")
                {
                    SendReply(player, "Chat color set to YELLOW");

                    rust.RunServerCommand("chat user add " + pName + " yellow");

                    rust.RunServerCommand("chat user remove " + pName + " red");
                    rust.RunServerCommand("chat user remove " + pName + " green");
                    rust.RunServerCommand("chat user remove " + pName + " blue");
                    rust.RunServerCommand("chat user remove " + pName + " orange");
                    rust.RunServerCommand("chat user remove " + pName + " pink");
                    rust.RunServerCommand("chat user remove " + pName + " white");
                    rust.RunServerCommand("chat user remove " + pName + " purple");

                    return;
                }
                if (args[0] == "yellow")
                {
                    SendReply(player, "Chat color set to YELLOW");

                    rust.RunServerCommand("chat user add " + pName + " yellow");

                    rust.RunServerCommand("chat user remove " + pName + " red");
                    rust.RunServerCommand("chat user remove " + pName + " green");
                    rust.RunServerCommand("chat user remove " + pName + " blue");
                    rust.RunServerCommand("chat user remove " + pName + " orange");
                    rust.RunServerCommand("chat user remove " + pName + " pink");
                    rust.RunServerCommand("chat user remove " + pName + " white");
                    rust.RunServerCommand("chat user remove " + pName + " purple");

                    return;
                }
                // ORANGE
                if (args[0] == "Orange")
                {
                    SendReply(player, "Chat color set to ORANGE");

                    rust.RunServerCommand("chat user add " + pName + " orange");

                    rust.RunServerCommand("chat user remove " + pName + " red");
                    rust.RunServerCommand("chat user remove " + pName + " green");
                    rust.RunServerCommand("chat user remove " + pName + " yellow");
                    rust.RunServerCommand("chat user remove " + pName + " blue");
                    rust.RunServerCommand("chat user remove " + pName + " pink");
                    rust.RunServerCommand("chat user remove " + pName + " white");
                    rust.RunServerCommand("chat user remove " + pName + " purple");

                    return;
                }
                if (args[0] == "orange")
                {
                    SendReply(player, "Chat color set to ORANGE");

                    rust.RunServerCommand("chat user add " + pName + " orange");

                    rust.RunServerCommand("chat user remove " + pName + " red");
                    rust.RunServerCommand("chat user remove " + pName + " green");
                    rust.RunServerCommand("chat user remove " + pName + " yellow");
                    rust.RunServerCommand("chat user remove " + pName + " blue");
                    rust.RunServerCommand("chat user remove " + pName + " pink");
                    rust.RunServerCommand("chat user remove " + pName + " white");
                    rust.RunServerCommand("chat user remove " + pName + " purple");

                    return;
                }
                // PINK
                if (args[0] == "Pink")
                {
                    SendReply(player, "Chat color set to PINK");

                    rust.RunServerCommand("chat user add " + pName + " pink");

                    rust.RunServerCommand("chat user remove " + pName + " red");
                    rust.RunServerCommand("chat user remove " + pName + " green");
                    rust.RunServerCommand("chat user remove " + pName + " yellow");
                    rust.RunServerCommand("chat user remove " + pName + " orange");
                    rust.RunServerCommand("chat user remove " + pName + " blue");
                    rust.RunServerCommand("chat user remove " + pName + " white");
                    rust.RunServerCommand("chat user remove " + pName + " purple");

                    return;
                }
                if (args[0] == "pink")
                {
                    SendReply(player, "Chat color set to PINK");

                    rust.RunServerCommand("chat user add " + pName + " pink");

                    rust.RunServerCommand("chat user remove " + pName + " red");
                    rust.RunServerCommand("chat user remove " + pName + " green");
                    rust.RunServerCommand("chat user remove " + pName + " yellow");
                    rust.RunServerCommand("chat user remove " + pName + " orange");
                    rust.RunServerCommand("chat user remove " + pName + " blue");
                    rust.RunServerCommand("chat user remove " + pName + " white");
                    rust.RunServerCommand("chat user remove " + pName + " purple");

                    return;
                }
                // WHITE
                if (args[0] == "White")
                {
                    SendReply(player, "Chat color set to WHITE");

                    rust.RunServerCommand("chat user add " + pName + " white");

                    rust.RunServerCommand("chat user remove " + pName + " red");
                    rust.RunServerCommand("chat user remove " + pName + " green");
                    rust.RunServerCommand("chat user remove " + pName + " yellow");
                    rust.RunServerCommand("chat user remove " + pName + " orange");
                    rust.RunServerCommand("chat user remove " + pName + " pink");
                    rust.RunServerCommand("chat user remove " + pName + " blue");
                    rust.RunServerCommand("chat user remove " + pName + " purple");

                    return;
                }
                if (args[0] == "white")
                {
                    SendReply(player, "Chat color set to WHITE");

                    rust.RunServerCommand("chat user add " + pName + " white");

                    rust.RunServerCommand("chat user remove " + pName + " red");
                    rust.RunServerCommand("chat user remove " + pName + " green");
                    rust.RunServerCommand("chat user remove " + pName + " yellow");
                    rust.RunServerCommand("chat user remove " + pName + " orange");
                    rust.RunServerCommand("chat user remove " + pName + " pink");
                    rust.RunServerCommand("chat user remove " + pName + " blue");
                    rust.RunServerCommand("chat user remove " + pName + " purple");

                    return;
                }
                // PURPLE
                if (args[0] == "Purple")
                {
                    SendReply(player, "Chat color set to PURPLE");

                    rust.RunServerCommand("chat user add " + pName + " purple");

                    rust.RunServerCommand("chat user remove " + pName + " red");
                    rust.RunServerCommand("chat user remove " + pName + " green");
                    rust.RunServerCommand("chat user remove " + pName + " yellow");
                    rust.RunServerCommand("chat user remove " + pName + " orange");
                    rust.RunServerCommand("chat user remove " + pName + " pink");
                    rust.RunServerCommand("chat user remove " + pName + " white");
                    rust.RunServerCommand("chat user remove " + pName + " blue");

                    return;
                }
                if (args[0] == "purple")
                {
                    SendReply(player, "Chat color set to PURPLE");

                    rust.RunServerCommand("chat user add " + pName + " purple");

                    rust.RunServerCommand("chat user remove " + pName + " red");
                    rust.RunServerCommand("chat user remove " + pName + " green");
                    rust.RunServerCommand("chat user remove " + pName + " yellow");
                    rust.RunServerCommand("chat user remove " + pName + " orange");
                    rust.RunServerCommand("chat user remove " + pName + " pink");
                    rust.RunServerCommand("chat user remove " + pName + " white");
                    rust.RunServerCommand("chat user remove " + pName + " blue");

                    return;
                }
                // RESET
                if (args[0] == "Reset")
                {
                    SendReply(player, "Chat color RESET");

                    rust.RunServerCommand("chat user remove " + pName + " red");
                    rust.RunServerCommand("chat user remove " + pName + " blue");
                    rust.RunServerCommand("chat user remove " + pName + " green");
                    rust.RunServerCommand("chat user remove " + pName + " yellow");
                    rust.RunServerCommand("chat user remove " + pName + " orange");
                    rust.RunServerCommand("chat user remove " + pName + " pink");
                    rust.RunServerCommand("chat user remove " + pName + " white");
                    rust.RunServerCommand("chat user remove " + pName + " purple");

                    return;
                }
                if (args[0] == "reset")
                {
                    SendReply(player, "Chat color RESET");

                    rust.RunServerCommand("chat user remove " + pName + " red");
                    rust.RunServerCommand("chat user remove " + pName + " blue");
                    rust.RunServerCommand("chat user remove " + pName + " green");
                    rust.RunServerCommand("chat user remove " + pName + " yellow");
                    rust.RunServerCommand("chat user remove " + pName + " orange");
                    rust.RunServerCommand("chat user remove " + pName + " pink");
                    rust.RunServerCommand("chat user remove " + pName + " white");
                    rust.RunServerCommand("chat user remove " + pName + " purple");

                    return;
                }
                else
                {
                    SendReply(player, "Invalid Arguments");
                    return;
                }
            }
            else if (args.Length > 1)
            {
                SendReply(player, "Too many args");
            }
        }
    }
}

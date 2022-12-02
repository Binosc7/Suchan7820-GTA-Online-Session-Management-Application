@echo off
mode con cols=15 lines=1
netsh advfirewall firewall delete rule name="[Suchan7820]GTA Online Session Firewall TCP Inbound" dir=in
netsh advfirewall firewall delete rule name="[Suchan7820]GTA Online Session Firewall UDP Inbound" dir=in
netsh advfirewall firewall delete rule name="[Suchan7820]GTA Online Session Firewall TCP Outbound" dir=out
netsh advfirewall firewall delete rule name="[Suchan7820]GTA Online Session Firewall UDP Outbound" dir=out
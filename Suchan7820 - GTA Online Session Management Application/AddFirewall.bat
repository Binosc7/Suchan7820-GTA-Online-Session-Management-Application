@echo off
mode con cols=15 lines=1
netsh advfirewall firewall add rule name="[Suchan7820]GTA Online Session Firewall TCP Inbound" dir=in action=block protocol=TCP localport=6672,61455,61456,61457,61458
netsh advfirewall firewall add rule name="[Suchan7820]GTA Online Session Firewall UDP Inbound" dir=in action=block protocol=UDP localport=6672,61455,61456,61457,61458
netsh advfirewall firewall add rule name="[Suchan7820]GTA Online Session Firewall TCP Outbound" dir=out action=block protocol=TCP localport=6672,61455,61456,61457,61458
netsh advfirewall firewall add rule name="[Suchan7820]GTA Online Session Firewall UDP Outbound" dir=out action=block protocol=UDP localport=6672,61455,61456,61457,61458
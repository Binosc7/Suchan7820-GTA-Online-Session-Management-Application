@echo off
mode con cols=15 lines=1
netsh advfirewall firewall add rule name="[Suchan7820]GTA Online Session Firewall TCP" dir=out action=block protocol=TCP localport=6672,61455,61456,61457,61458
netsh advfirewall firewall add rule name="[Suchan7820]GTA Online Session Firewall UDP" dir=out action=block protocol=UDP localport=6672,61455,61456,61457,61458
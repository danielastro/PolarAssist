# PolarAssist
Most german equatorial mounts have the ability to install a polar scope, used to orient the mount with the North Celestial Pole. 
Polaris, The north star, is almost at NCP but not exactly on it. depending on the time of day, it circles around NCP
In astronomy, sidereal time is used to translate the object (star) coordinates into a position in the sky.
a star coordinate is given in RA(right ascension) and Dec (declination)
Position in the sky is given in Altitude and Azimuth.

to align the scope mount perfectly with the NCP, the principle is simple. the polar scope has a bullseye where
Polaris should be, the mount is rotated to place the bullseye at the right place (depending on sidereal time)
and then the mount altitude and azimuth are ajusted so polaris falls inside the Bullseye.

The more precise it is aligned, the more precise the star tracking.

rotating the mount by hand to place the bullseye is not precise and this is exactly what this application is helping with. 

The app uses the ASCOM standard to connect to the mount.

The application is configured with the default position of the bullseye on the polar scope. This can be done 2 methods, 
the first one is calculating the angle of your bullseye by reading the mount position with the bullseye at the top (0 degrees)
or at the bottom (180 degrees), but this requires the mount to be connected. The second method ask you to manually 
enter the angle.

Once configured, the connection can take place. depending on the sidereal time, and taking into consideration that the
mount cannot slew (rotate) a full 360 degrees, the app offers to slew the scope to the exact position to place the bullseye
for Polaris where it should be, and also turn the mount sideways to unblock the polar scope view. 

This works presently with my Celesteon AVX mount, but it can be adapted for other mounts if there are slight differences.

I am very green with VB.net so the app is very incomplete. many error conditions have not been dealth with (error handling).
many buttons labels have not been locked properly so they could be moved (more work to do in this area)
but it does the important task of orienting the bullseye as it should...

feel free to assist, suggest mods, and adapt it to your own mount.

Daniel

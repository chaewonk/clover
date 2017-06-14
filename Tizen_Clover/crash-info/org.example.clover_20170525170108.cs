S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.1
Build-Number: R760XXU1APL2
Build-Date: 2016.12.20 22:57:01

Crash Information
Process Name: clover
PID: 9080
Date: 2017-05-25 17:01:08+0900
Executable File Path: /opt/usr/apps/org.example.clover/bin/clover
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 9080, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0xf5d1a26c, r3   = 0x00000001
r4   = 0xf70e29b8, r5   = 0xf70e29b8
r6   = 0xf70e216c, r7   = 0xffb7fff0
r8   = 0xf70e29b8, r9   = 0xf77cde10
r10  = 0xf70f0b10, fp   = 0x00000000
ip   = 0xf5d1a2ac, sp   = 0xffb7ffa8
lr   = 0xf6ea65d0, pc   = 0xf5d06562
cpsr = 0x60000030

Memory Information
MemTotal:   714608 KB
MemFree:      5016 KB
Buffers:     42668 KB
Cached:     169740 KB
VmPeak:     198280 KB
VmSize:     197184 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       36288 KB
VmRSS:       36284 KB
VmData:     119064 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       29400 KB
VmPTE:         192 KB
VmSwap:          0 KB

Threads Information
Threads: 11
PID = 9080 TID = 9080
9080 9371 9372 9382 9383 9384 9385 9386 9387 9388 9389 

Maps Information
ed0fe000 ed8fd000 rw-p [stack:9389]
ed8fe000 ee4fe000 rw-p [stack:9388]
ee4ff000 eecfe000 rw-p [stack:9387]
eecff000 ef4fe000 rw-p [stack:9386]
efd01000 f0500000 rw-p [stack:9385]
f0501000 f0d00000 rw-p [stack:9384]
f0e41000 f0e44000 r-xp /usr/lib/gstreamer-0.10/libgstwavenc.so
f0e4c000 f0e66000 r-xp /usr/lib/gstreamer-0.10/libgstpulse.so
f0e6f000 f0ea7000 r-xp /usr/lib/libsamrnb.so
f0eca000 f0ed5000 r-xp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
f0ede000 f0eee000 r-xp /usr/lib/gstreamer-0.10/libgstalsa.so
f0ef6000 f0efc000 r-xp /usr/lib/libscmn.so
f0f04000 f0f3c000 r-xp /usr/lib/libsaac.so
f0f46000 f0f4b000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencamrnb.so
f0f53000 f0f63000 r-xp /usr/lib/lib_SamsungRec_TizenV04015.so
f0f84000 f0f8c000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
f0f9b000 f0fa0000 r-xp /usr/lib/gstreamer-0.10/libgstsecrecord.so
f0fb2000 f0fca000 r-xp /usr/lib/libgstcontroller-0.10.so.0.30.0
f0fda000 f0fe0000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencaac.so
f0fe8000 f1000000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
f1009000 f1032000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
f1044000 f1049000 r-xp /usr/lib/gstreamer-0.10/libgstvolume.so
f1051000 f11af000 r-xp /usr/lib/gstreamer-0.10/libgstffmpeg.so
f1297000 f12a3000 r-xp /usr/lib/gstreamer-0.10/libgstencodebin.so
f12ab000 f12cb000 r-xp /usr/lib/gstreamer-0.10/libgstomx.so
f12cc000 f1300000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
f1309000 f1314000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
f131c000 f131e000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
f1326000 f1327000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
f132f000 f1337000 r-xp /usr/lib/libfeedback.so.0.1.4
f133c000 f133f000 r-xp /usr/lib/gstreamer-0.10/libgstavsysaudiosrc.so
f1347000 f1348000 r-xp /usr/lib/gstreamer-0.10/libgstapp.so
f1350000 f1351000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
f135a000 f1b59000 rw-p [stack:9372]
f1b5a000 f2359000 rw-p [stack:9371]
f2401000 f2c00000 rw-p [stack:9382]
f2d08000 f2d09000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
f2d11000 f2d14000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
f2d1c000 f2d1d000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
f2e60000 f365f000 rw-p [stack:9383]
f365f000 f3661000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
f3669000 f3680000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f368d000 f3692000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f369a000 f36a5000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f39df000 f3ad1000 r-xp /usr/lib/libCOREGL.so.4.0
f3aea000 f3aef000 r-xp /usr/lib/libsystem.so.0.0.0
f3af9000 f3afa000 r-xp /usr/lib/libresponse.so.0.2.96
f3b02000 f3b07000 r-xp /usr/lib/libproc-stat.so.0.2.96
f3b10000 f3b12000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f3b1a000 f3b21000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f3b2a000 f3b4c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f3b55000 f3b59000 r-xp /usr/lib/libogg.so.0.7.1
f3b61000 f3b83000 r-xp /usr/lib/libvorbis.so.0.4.3
f3b8b000 f3b8e000 r-xp /usr/lib/libtinycompress.so.0.0.0
f3b96000 f3ba5000 r-xp /usr/lib/libmdm-common.so.1.1.22
f3bae000 f3bb6000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f3bbe000 f3bc4000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f3bcd000 f3bd4000 r-xp /usr/lib/libminizip.so.1.0.0
f3bdc000 f3bde000 r-xp /usr/lib/libttrace.so.1.1
f3be6000 f3c2d000 r-xp /usr/lib/libsndfile.so.1.0.26
f3c39000 f3c82000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f3c8b000 f3c90000 r-xp /usr/lib/libjson.so.0.0.1
f5529000 f562f000 r-xp /usr/lib/libicuuc.so.57.1
f5645000 f57cd000 r-xp /usr/lib/libicui18n.so.57.1
f57dd000 f57ea000 r-xp /usr/lib/libail.so.0.1.0
f57f3000 f57f6000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f57fe000 f5801000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f5809000 f586a000 r-xp /usr/lib/libasound.so.2.0.0
f5874000 f588a000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f5892000 f5896000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f589e000 f58df000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
f58e8000 f58ea000 r-xp /usr/lib/libdri2.so.0.0.0
f58f2000 f58fa000 r-xp /usr/lib/libdrm.so.2.4.0
f5902000 f5908000 r-xp /usr/lib/libxcb-render.so.0.0.0
f5910000 f5911000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f591a000 f591e000 r-xp /usr/lib/libEGL.so.1.4
f592e000 f593f000 r-xp /usr/lib/libGLESv2.so.2.0
f594f000 f5997000 r-xp /usr/lib/libmdm.so.1.2.62
f5998000 f599f000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f59a7000 f59b2000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f59bf000 f59d8000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f59e0000 f59e5000 r-xp /usr/lib/libstorage.so.0.1
f59ed000 f59f2000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f59fa000 f5a32000 r-xp /usr/lib/libpulse.so.0.16.2
f5a33000 f5a37000 r-xp /usr/lib/libmmfsession.so.0.0.0
f5a40000 f5a57000 r-xp /usr/lib/libmmfsound.so.0.1.0
f5a69000 f5a8a000 r-xp /usr/lib/libexif.so.12.3.3
f5a9d000 f5aa6000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
f5aae000 f5abb000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
f5ac4000 f5acf000 r-xp /usr/lib/libtbm.so.1.0.0
f5ad7000 f5adc000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f5ae4000 f5b9c000 r-xp /usr/lib/libcairo.so.2.11200.14
f5ba7000 f5c42000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
f5c4e000 f5c9e000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
f5ca4000 f5cb6000 r-xp /usr/lib/libcapi-media-camera.so.0.1.35
f5cbe000 f5cdf000 r-xp /usr/lib/libefl-extension.so.0.1.0
f5ce7000 f5cec000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5cf4000 f5cfc000 r-xp /usr/lib/libcapi-media-recorder.so.0.1.28
f5d04000 f5d0b000 r-xp /opt/usr/apps/org.example.clover/bin/clover
f5ead000 f5eb7000 r-xp /lib/libnss_files-2.13.so
f5ec0000 f5f8f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f5fa5000 f5fc9000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f5fd2000 f5fd8000 r-xp /usr/lib/libappsvc.so.0.1.0
f5fe0000 f5fe2000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f5feb000 f5fef000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f5ffb000 f6006000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f600e000 f6010000 r-xp /usr/lib/libiniparser.so.0
f6019000 f601e000 r-xp /usr/lib/libappcore-common.so.1.1
f6026000 f6028000 r-xp /usr/lib/libcamsrcjpegenc.so.0.0.0
f6030000 f6034000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f6041000 f6043000 r-xp /usr/lib/libXau.so.6.0.0
f604b000 f6052000 r-xp /lib/libcrypt-2.13.so
f6082000 f6084000 r-xp /usr/lib/libiri.so
f608d000 f6236000 r-xp /usr/lib/libcrypto.so.1.0.0
f6256000 f629d000 r-xp /usr/lib/libssl.so.1.0.0
f62a9000 f62d7000 r-xp /usr/lib/libidn.so.11.5.44
f62df000 f62e8000 r-xp /usr/lib/libcares.so.2.1.0
f62f2000 f6305000 r-xp /usr/lib/libxcb.so.1.1.0
f630e000 f6310000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6318000 f631a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6323000 f63ef000 r-xp /usr/lib/libxml2.so.2.7.8
f63fc000 f63fe000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6407000 f640c000 r-xp /usr/lib/libffi.so.5.0.10
f6414000 f6415000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f641d000 f6420000 r-xp /lib/libattr.so.1.1.0
f6428000 f64bc000 r-xp /usr/lib/libstdc++.so.6.0.16
f64cf000 f64ec000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f64f6000 f650e000 r-xp /usr/lib/libpng12.so.0.50.0
f6516000 f652c000 r-xp /lib/libexpat.so.1.6.0
f6536000 f657a000 r-xp /usr/lib/libcurl.so.4.3.0
f6583000 f658d000 r-xp /usr/lib/libXext.so.6.4.0
f6596000 f659a000 r-xp /usr/lib/libXtst.so.6.1.0
f65a2000 f65a8000 r-xp /usr/lib/libXrender.so.1.3.0
f65b0000 f65b6000 r-xp /usr/lib/libXrandr.so.2.2.0
f65be000 f65bf000 r-xp /usr/lib/libXinerama.so.1.0.0
f65c8000 f65d1000 r-xp /usr/lib/libXi.so.6.1.0
f65d9000 f65dc000 r-xp /usr/lib/libXfixes.so.3.1.0
f65e4000 f65e6000 r-xp /usr/lib/libXgesture.so.7.0.0
f65ee000 f65f0000 r-xp /usr/lib/libXcomposite.so.1.0.0
f65f8000 f65fa000 r-xp /usr/lib/libXdamage.so.1.1.0
f6602000 f6609000 r-xp /usr/lib/libXcursor.so.1.0.2
f6611000 f6614000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f661c000 f6620000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f6629000 f662e000 r-xp /usr/lib/libecore_fb.so.1.7.99
f6637000 f6718000 r-xp /usr/lib/libX11.so.6.3.0
f6723000 f6746000 r-xp /usr/lib/libjpeg.so.8.0.2
f675e000 f6774000 r-xp /lib/libz.so.1.2.5
f677c000 f677e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6786000 f67fb000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6805000 f681f000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6827000 f685b000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6864000 f6937000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6942000 f6952000 r-xp /lib/libresolv-2.13.so
f6956000 f696e000 r-xp /usr/lib/liblzma.so.5.0.3
f6976000 f6979000 r-xp /lib/libcap.so.2.21
f6981000 f69b0000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f69b8000 f69b9000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f69c1000 f69c7000 r-xp /usr/lib/libecore_imf.so.1.7.99
f69cf000 f69e6000 r-xp /usr/lib/liblua-5.1.so
f69ef000 f69f6000 r-xp /usr/lib/libembryo.so.1.7.99
f69fe000 f6a04000 r-xp /lib/librt-2.13.so
f6a0d000 f6a63000 r-xp /usr/lib/libpixman-1.so.0.28.2
f6a70000 f6ac6000 r-xp /usr/lib/libfreetype.so.6.11.3
f6ad2000 f6afa000 r-xp /usr/lib/libfontconfig.so.1.8.0
f6afb000 f6b40000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6b49000 f6b5c000 r-xp /usr/lib/libfribidi.so.0.3.1
f6b64000 f6b7e000 r-xp /usr/lib/libecore_con.so.1.7.99
f6b87000 f6b90000 r-xp /usr/lib/libedbus.so.1.7.99
f6b98000 f6be8000 r-xp /usr/lib/libecore_x.so.1.7.99
f6bea000 f6bf3000 r-xp /usr/lib/libvconf.so.0.2.45
f6bfb000 f6c0c000 r-xp /usr/lib/libecore_input.so.1.7.99
f6c14000 f6c19000 r-xp /usr/lib/libecore_file.so.1.7.99
f6c21000 f6c43000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6c4c000 f6c8d000 r-xp /usr/lib/libeina.so.1.7.99
f6c96000 f6caf000 r-xp /usr/lib/libeet.so.1.7.99
f6cc0000 f6d29000 r-xp /lib/libm-2.13.so
f6d32000 f6d38000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d41000 f6d42000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d4a000 f6d6d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d75000 f6d7a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d82000 f6dac000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6db5000 f6dcc000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6dd4000 f6ddf000 r-xp /lib/libunwind.so.8.0.1
f6e0c000 f6e2a000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e34000 f6f58000 r-xp /lib/libc-2.13.so
f6f66000 f6f6e000 r-xp /lib/libgcc_s-4.6.so.1
f6f6f000 f6f73000 r-xp /usr/lib/libsmack.so.1.0.0
f6f7c000 f6f82000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f6f8a000 f705a000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f705b000 f70b9000 r-xp /usr/lib/libedje.so.1.7.99
f70c3000 f70da000 r-xp /usr/lib/libecore.so.1.7.99
f70f1000 f71bf000 r-xp /usr/lib/libevas.so.1.7.99
f71e4000 f7320000 r-xp /usr/lib/libelementary.so.1.7.99
f7337000 f734b000 r-xp /lib/libpthread-2.13.so
f7356000 f7358000 r-xp /usr/lib/libdlog.so.0.0.0
f7360000 f7363000 r-xp /usr/lib/libbundle.so.0.1.22
f736b000 f736d000 r-xp /lib/libdl-2.13.so
f7376000 f7383000 r-xp /usr/lib/libaul.so.0.1.0
f7394000 f739a000 r-xp /usr/lib/libappcore-efl.so.1.1
f73a3000 f73a7000 r-xp /usr/lib/libsys-assert.so
f73b0000 f73cd000 r-xp /lib/ld-2.13.so
f73d6000 f73db000 r-xp /usr/bin/launchpad-loader
f7795000 f78ff000 rw-p [heap]
ffb60000 ffb81000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9080)
Call Stack Count: 12
 0: ecore_timer_cb + 0xc9 (0xf5d06562) [/opt/usr/apps/org.example.clover/bin/clover] + 0x2562
 1: (0xf70d21f9) [/usr/lib/libecore.so.1] + 0xf1f9
 2: (0xf70d22ef) [/usr/lib/libecore.so.1] + 0xf2ef
 3: (0xf70cf2f3) [/usr/lib/libecore.so.1] + 0xc2f3
 4: ecore_main_loop_begin + 0x30 (0xf70cf879) [/usr/lib/libecore.so.1] + 0xc879
 5: appcore_efl_main + 0x332 (0xf7397b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
 6: ui_app_main + 0xb0 (0xf6032421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 7: uib_app_run + 0xea (0xf5d06ef3) [/opt/usr/apps/org.example.clover/bin/clover] + 0x2ef3
 8: main + 0x34 (0xf5d06489) [/opt/usr/apps/org.example.clover/bin/clover] + 0x2489
 9: (0xf73d7a53) [/opt/usr/apps/org.example.clover/bin/clover] + 0x1a53
10: __libc_start_main + 0x114 (0xf6e4b85c) [/lib/libc.so.6] + 0x1785c
11: (0xf73d7e0c) [/opt/usr/apps/org.example.clover/bin/clover] + 0x1e0c
End of Call Stack

Package Information
Package Name: org.example.clover
Package ID : org.example.clover
Version: 1.0.0
Package Type: rpm
App Name: clover
App ID: org.example.clover
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
elc_naviframe.c:2796 _push_transition_cb() item(0xf2ca7a60) will transition
05-25 17:00:20.831+0900 E/EFL     ( 9080): elementary<9080> elc_naviframe.c:1193 _on_item_push_finished() item(0xf2c2a7e0) transition finished
05-25 17:00:20.831+0900 E/EFL     ( 9080): elementary<9080> elc_naviframe.c:1218 _on_item_show_finished() item(0xf2ca7a60) transition finished
05-25 17:00:21.001+0900 E/EFL     ( 2318): ecore_x<2318> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x4600002 time=3665737
05-25 17:00:21.001+0900 E/EFL     ( 9080): ecore_x<9080> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=3665737
05-25 17:00:21.001+0900 E/EFL     ( 2318): ecore_x<2318> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=3665737
05-25 17:00:34.411+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_unset_buffer(1602) > [3679.754153] layer(0x874fb8) now usable
05-25 17:00:34.411+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [3679.754210] layer[0x874b08]zpos[1]
05-25 17:00:34.411+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_unset_buffer(1602) > [3679.754266] layer(0x875008) now usable
05-25 17:00:34.411+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [3679.754288] layer[0x874c28]zpos[2]
05-25 17:00:34.411+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [3679.754313] dpms[0 -> 3]sync[1]
05-25 17:00:34.411+0900 I/TDM     ( 1552): 
05-25 17:00:34.441+0900 W/WATCH_CORE( 2779): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
05-25 17:00:34.441+0900 W/W_HOME  ( 2724): dbus.c: _dbus_message_recv_cb(204) > LCD off
05-25 17:00:34.441+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
05-25 17:00:34.441+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_disable_timer_del(157) > timer del
05-25 17:00:34.441+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_enable(138) > 1
05-25 17:00:34.441+0900 W/W_HOME  ( 2724): event_manager.c: _lcd_off_cb(736) > lcd state: 0
05-25 17:00:34.441+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:00:34.451+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -147223796[0;m
05-25 17:00:34.451+0900 W/STARTER ( 2650): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [timeout]
05-25 17:00:34.451+0900 W/STARTER ( 2650): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
05-25 17:00:34.451+0900 E/STARTER ( 2650): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
05-25 17:00:34.451+0900 W/STARTER ( 2650): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
05-25 17:00:34.451+0900 W/STARTER ( 2650): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
05-25 17:00:34.471+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
05-25 17:00:34.471+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
05-25 17:00:34.471+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
05-25 17:00:34.481+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
05-25 17:00:34.481+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
05-25 17:00:34.481+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
05-25 17:00:34.491+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
05-25 17:00:34.491+0900 W/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-25 17:00:34.491+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
05-25 17:00:34.491+0900 I/HIGEAR  ( 3216): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
05-25 17:00:34.551+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [3679.891248] dpms[3 -> 3]done
05-25 17:00:34.551+0900 I/TDM     ( 1552): 
05-25 17:00:34.551+0900 W/SHealthCommon( 3233): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:3[0;m
05-25 17:00:34.561+0900 W/SHealthService( 3233): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-25 17:00:34.561+0900 W/SHealthCommon( 2843): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:3[0;m
05-25 17:00:34.561+0900 W/W_INDICATOR( 2651): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1504) > [windicator_hide_moment_bar_directly:1504] windicator_hide_moment_bar_directly
05-25 17:00:34.571+0900 W/STARTER ( 2650): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [timeout]
05-25 17:00:34.571+0900 W/STARTER ( 2650): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[0]
05-25 17:00:34.571+0900 W/STARTER ( 2650): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
05-25 17:00:34.571+0900 W/STARTER ( 2650): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[0]
05-25 17:00:34.571+0900 E/ALARM_MANAGER( 2650): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(20), start(25-5-2017, 17:00:55), repeat(1), interval(20), type(-1073741822)
05-25 17:00:34.571+0900 I/APP_CORE( 9080): appcore-efl.c: __do_app(453) > [APP 9080] Event: PAUSE State: RUNNING
05-25 17:00:34.571+0900 I/CAPI_APPFW_APPLICATION( 9080): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-25 17:00:34.581+0900 W/APP_CORE( 9080): appcore-efl.c: _capture_and_make_file(1721) > Capture : win[4600002] -> redirected win[603c01] for org.example.clover[9080]
05-25 17:00:34.581+0900 W/W_INDICATOR( 2651): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
05-25 17:00:34.581+0900 W/W_INDICATOR( 2651): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
05-25 17:00:34.581+0900 W/W_INDICATOR( 2651): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1504) > [windicator_hide_moment_bar_directly:1504] windicator_hide_moment_bar_directly
05-25 17:00:34.591+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2650].
05-25 17:00:34.621+0900 E/ALARM_MANAGER( 2443): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1160254344, next duetime: 1495699255
05-25 17:00:34.621+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(1160254344)
05-25 17:00:34.631+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1495699828), due_time(1495699255)
05-25 17:00:34.641+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
05-25 17:00:34.641+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-25 17:00:34.641+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 25-5-2017, 08:00:55 (UTC).
05-25 17:00:34.641+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-25 17:00:34.651+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
05-25 17:00:39.581+0900 I/APP_CORE( 9080): appcore-efl.c: __do_app(453) > [APP 9080] Event: MEM_FLUSH State: PAUSED
05-25 17:00:43.001+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [3688.341625] dpms[3 -> 0]sync[0]
05-25 17:00:43.001+0900 I/TDM     ( 1552): 
05-25 17:00:43.001+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [3688.341788] dpms[0 -> 0]done
05-25 17:00:43.001+0900 I/TDM     ( 1552): 
05-25 17:00:43.001+0900 W/SHealthCommon( 3233): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:1[0;m
05-25 17:00:43.001+0900 W/SHealthService( 3233): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-25 17:00:43.001+0900 W/SHealthCommon( 2843): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:1[0;m
05-25 17:00:43.011+0900 W/wnotibp ( 3231): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(91) > ::APP:: view state=0, 2, 0
05-25 17:00:43.011+0900 I/wnotibp ( 3231): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(140) > There is no additional work.
05-25 17:00:43.011+0900 W/WATCH_CORE( 2779): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOn
05-25 17:00:43.011+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_lcd_status_handler(1250) > Call the time_tick_cb
05-25 17:00:43.021+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:00:43.021+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_lcd_status_handler(1257) > Call widget_provider_update_event
05-25 17:00:43.021+0900 W/W_HOME  ( 2724): dbus.c: _dbus_message_recv_cb(186) > LCD on
05-25 17:00:43.021+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_disable_timer_set(167) > timer set
05-25 17:00:43.021+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_disable_timer_del(157) > timer del
05-25 17:00:43.021+0900 W/W_HOME  ( 2724): gesture.c: _apps_status_get(128) > apps status:0
05-25 17:00:43.021+0900 W/W_HOME  ( 2724): gesture.c: _lcd_on_cb(303) > move_to_clock:0 clock_visible:0 info->offtime:8599
05-25 17:00:43.021+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_schedule(209) > schedule, manual render
05-25 17:00:43.021+0900 W/W_HOME  ( 2724): event_manager.c: _lcd_on_cb(728) > lcd state: 1
05-25 17:00:43.021+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:00:43.021+0900 W/STARTER ( 2650): clock-mgr.c: _on_lcd_signal_receive_cb(1579) > [_on_lcd_signal_receive_cb:1579] _on_lcd_signal_receive_cb, 1579, Pre LCD on by [unknown] after screen off time [8599]ms
05-25 17:00:43.021+0900 W/STARTER ( 2650): clock-mgr.c: _pre_lcd_on(1298) > [_pre_lcd_on:1298] Will LCD ON as reserved app[(null)] alpm mode[0]
05-25 17:00:43.021+0900 W/W_INDICATOR( 2651): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(285) > [_windicator_dbus_lcd_changed_cb:285] LCD ON signal is received
05-25 17:00:43.021+0900 W/W_INDICATOR( 2651): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] 304, str=[unknown],charge : 0, connected : 0
05-25 17:00:43.021+0900 I/APP_CORE( 9080): appcore-efl.c: __do_app(453) > [APP 9080] Event: RESUME State: PAUSED
05-25 17:00:43.021+0900 I/CAPI_APPFW_APPLICATION( 9080): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-25 17:00:43.031+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : -147223796[0;m
05-25 17:00:43.031+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
05-25 17:00:43.031+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-25 17:00:43.031+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
05-25 17:00:43.031+0900 W/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
05-25 17:00:43.031+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
05-25 17:00:43.031+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
05-25 17:00:43.041+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
05-25 17:00:43.041+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
05-25 17:00:43.041+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2650].
05-25 17:00:43.041+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(1160254344)
05-25 17:00:43.041+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
05-25 17:00:43.041+0900 W/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-25 17:00:43.041+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
05-25 17:00:43.041+0900 I/HIGEAR  ( 3216): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
05-25 17:00:43.061+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_set_info(1442) > [3688.402901] layer(0x874fb8) not usable
05-25 17:00:43.061+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_set_info(1459) > [3688.402966] layer(0x874fb8) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
05-25 17:00:43.061+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_layer_set_info(1578) > [3688.402989] layer[0x874b08]zpos[1]
05-25 17:00:43.061+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_set_info(1442) > [3688.403063] layer(0x875008) not usable
05-25 17:00:43.061+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_set_info(1459) > [3688.403079] layer(0x875008) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
05-25 17:00:43.061+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_layer_set_info(1578) > [3688.403097] layer[0x874c28]zpos[2]
05-25 17:00:43.061+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
05-25 17:00:43.061+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
05-25 17:00:43.061+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: preference_get_boolean(1173) > preference_get_boolean(3233) : test_healthy_pace error
05-25 17:00:43.081+0900 W/SHealthCommon( 3233): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1495670400000.000000[0;m
05-25 17:00:43.101+0900 W/SHealthCommon( 3233): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.widget.hrlog (916859)]][0;m
05-25 17:00:43.131+0900 W/SHealthCommon( 3233): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.1.30][0;m
05-25 17:00:43.131+0900 W/SHealthWidget( 2843): WidgetMain.cpp: widget_update(147) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.widget.hrlog (916859), msgName: timeline_summary_updated[0;m
05-25 17:00:43.131+0900 W/SHealthCommon( 2843): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
05-25 17:00:43.131+0900 W/SHealthWidget( 2843): HrLogWidgetViewController.cpp: OnIpcProxyMessageReceived(71) > [1;35m##24Hour Widget Service SummaryUpdate Called[0;m
05-25 17:00:43.131+0900 W/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1495731643144.000000, pattern:[HH:mm][0;m
05-25 17:00:43.131+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-25 17:00:43.131+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-25 17:00:43.131+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-25 17:00:43.131+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-25 17:00:43.131+0900 I/HealthDataService( 2909): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-25 17:00:43.131+0900 E/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale ko_KR[0;m
05-25 17:00:43.131+0900 W/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:00][0;m
05-25 17:00:43.131+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-25 17:00:43.141+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-25 17:00:43.141+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-25 17:00:43.141+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-25 17:00:43.141+0900 I/CAPI_WIDGET_APPLICATION( 2843): widget_app.c: __provider_update_cb(281) > received updating signal
05-25 17:00:43.151+0900 I/healthData( 3233): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
05-25 17:00:43.221+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_disable_timer_cb(145) > timeout callback expired
05-25 17:00:43.221+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_enable(138) > 0
05-25 17:00:43.221+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
05-25 17:00:43.291+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
05-25 17:00:43.291+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-25 17:00:43.291+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 25-5-2017, 08:10:28 (UTC).
05-25 17:00:43.291+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-25 17:00:43.311+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
05-25 17:00:43.311+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: alarm_manager_alarm_delete(2460) > alarm_id[1160254344] is removed.
05-25 17:00:43.311+0900 W/STARTER ( 2650): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [unknown]
05-25 17:00:43.311+0900 W/STARTER ( 2650): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[0]
05-25 17:00:49.171+0900 E/WMS     ( 2450): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23510) > _wms_event_handler_cb_nomove_detector is called
05-25 17:00:57.761+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_unset_buffer(1602) > [3703.108347] layer(0x874fb8) now usable
05-25 17:00:57.761+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [3703.108423] layer[0x874b08]zpos[1]
05-25 17:00:57.761+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_unset_buffer(1602) > [3703.108482] layer(0x875008) now usable
05-25 17:00:57.761+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [3703.108502] layer[0x874c28]zpos[2]
05-25 17:00:57.761+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [3703.108554] dpms[0 -> 3]sync[1]
05-25 17:00:57.761+0900 I/TDM     ( 1552): 
05-25 17:00:57.791+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -147223796[0;m
05-25 17:00:57.791+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
05-25 17:00:57.791+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
05-25 17:00:57.801+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
05-25 17:00:57.801+0900 W/WATCH_CORE( 2779): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
05-25 17:00:57.801+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
05-25 17:00:57.801+0900 W/W_HOME  ( 2724): dbus.c: _dbus_message_recv_cb(204) > LCD off
05-25 17:00:57.801+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
05-25 17:00:57.801+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_disable_timer_del(157) > timer del
05-25 17:00:57.801+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_enable(138) > 1
05-25 17:00:57.801+0900 W/W_HOME  ( 2724): event_manager.c: _lcd_off_cb(736) > lcd state: 0
05-25 17:00:57.801+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:00:57.801+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
05-25 17:00:57.811+0900 W/STARTER ( 2650): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [timeout]
05-25 17:00:57.811+0900 W/STARTER ( 2650): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
05-25 17:00:57.811+0900 E/STARTER ( 2650): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
05-25 17:00:57.811+0900 W/STARTER ( 2650): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
05-25 17:00:57.811+0900 W/STARTER ( 2650): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
05-25 17:00:57.811+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
05-25 17:00:57.821+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
05-25 17:00:57.821+0900 W/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-25 17:00:57.821+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
05-25 17:00:57.821+0900 I/HIGEAR  ( 3216): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
05-25 17:00:57.901+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [3703.241328] dpms[3 -> 3]done
05-25 17:00:57.901+0900 I/TDM     ( 1552): 
05-25 17:00:57.901+0900 W/SHealthCommon( 3233): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:3[0;m
05-25 17:00:57.901+0900 W/SHealthService( 3233): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-25 17:00:57.911+0900 W/SHealthCommon( 2843): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:3[0;m
05-25 17:00:57.921+0900 W/STARTER ( 2650): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [timeout]
05-25 17:00:57.921+0900 W/STARTER ( 2650): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[0]
05-25 17:00:57.921+0900 W/STARTER ( 2650): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
05-25 17:00:57.921+0900 W/STARTER ( 2650): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[0]
05-25 17:00:57.921+0900 E/ALARM_MANAGER( 2650): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(20), start(25-5-2017, 17:01:18), repeat(1), interval(20), type(-1073741822)
05-25 17:00:57.921+0900 W/W_INDICATOR( 2651): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1504) > [windicator_hide_moment_bar_directly:1504] windicator_hide_moment_bar_directly
05-25 17:00:57.931+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2650].
05-25 17:00:57.931+0900 I/APP_CORE( 9080): appcore-efl.c: __do_app(453) > [APP 9080] Event: PAUSE State: RUNNING
05-25 17:00:57.931+0900 I/CAPI_APPFW_APPLICATION( 9080): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-25 17:00:57.931+0900 W/APP_CORE( 9080): appcore-efl.c: _capture_and_make_file(1721) > Capture : win[4600002] -> redirected win[603c01] for org.example.clover[9080]
05-25 17:00:57.941+0900 W/W_INDICATOR( 2651): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
05-25 17:00:57.941+0900 W/W_INDICATOR( 2651): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
05-25 17:00:57.941+0900 W/W_INDICATOR( 2651): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1504) > [windicator_hide_moment_bar_directly:1504] windicator_hide_moment_bar_directly
05-25 17:00:57.981+0900 E/ALARM_MANAGER( 2443): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 604734663, next duetime: 1495699278
05-25 17:00:57.981+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(604734663)
05-25 17:00:57.981+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1495699828), due_time(1495699278)
05-25 17:00:58.001+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
05-25 17:00:58.001+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-25 17:00:58.001+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 25-5-2017, 08:01:18 (UTC).
05-25 17:00:58.001+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-25 17:00:58.011+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
05-25 17:01:01.661+0900 W/SHealthCommon( 2843): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:1[0;m
05-25 17:01:01.671+0900 W/wnotibp ( 3231): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(91) > ::APP:: view state=0, 2, 0
05-25 17:01:01.671+0900 I/wnotibp ( 3231): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(140) > There is no additional work.
05-25 17:01:01.681+0900 W/WATCH_CORE( 2779): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOn
05-25 17:01:01.681+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_lcd_status_handler(1250) > Call the time_tick_cb
05-25 17:01:01.681+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:01:01.681+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_lcd_status_handler(1257) > Call widget_provider_update_event
05-25 17:01:01.681+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [3707.029029] dpms[3 -> 0]sync[0]
05-25 17:01:01.681+0900 I/TDM     ( 1552): 
05-25 17:01:01.681+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [3707.029209] dpms[0 -> 0]done
05-25 17:01:01.681+0900 I/TDM     ( 1552): 
05-25 17:01:01.691+0900 W/W_HOME  ( 2724): dbus.c: _dbus_message_recv_cb(186) > LCD on
05-25 17:01:01.711+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_disable_timer_set(167) > timer set
05-25 17:01:01.711+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_disable_timer_del(157) > timer del
05-25 17:01:01.711+0900 W/W_HOME  ( 2724): gesture.c: _apps_status_get(128) > apps status:0
05-25 17:01:01.711+0900 W/W_HOME  ( 2724): gesture.c: _lcd_on_cb(303) > move_to_clock:0 clock_visible:0 info->offtime:3900
05-25 17:01:01.711+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_schedule(209) > schedule, manual render
05-25 17:01:01.711+0900 W/W_HOME  ( 2724): event_manager.c: _lcd_on_cb(728) > lcd state: 1
05-25 17:01:01.701+0900 W/STARTER ( 2650): clock-mgr.c: _on_lcd_signal_receive_cb(1579) > [_on_lcd_signal_receive_cb:1579] _on_lcd_signal_receive_cb, 1579, Pre LCD on by [unknown] after screen off time [3900]ms
05-25 17:01:01.711+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:01:01.711+0900 W/STARTER ( 2650): clock-mgr.c: _pre_lcd_on(1298) > [_pre_lcd_on:1298] Will LCD ON as reserved app[(null)] alpm mode[0]
05-25 17:01:01.711+0900 I/APP_CORE( 9080): appcore-efl.c: __do_app(453) > [APP 9080] Event: RESUME State: PAUSED
05-25 17:01:01.711+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : -147223796[0;m
05-25 17:01:01.711+0900 W/SHealthCommon( 3233): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:1[0;m
05-25 17:01:01.721+0900 I/CAPI_APPFW_APPLICATION( 9080): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-25 17:01:01.711+0900 W/W_INDICATOR( 2651): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(285) > [_windicator_dbus_lcd_changed_cb:285] LCD ON signal is received
05-25 17:01:01.721+0900 W/SHealthService( 3233): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-25 17:01:01.721+0900 W/W_INDICATOR( 2651): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] 304, str=[unknown],charge : 0, connected : 0
05-25 17:01:01.721+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
05-25 17:01:01.721+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-25 17:01:01.731+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
05-25 17:01:01.731+0900 W/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
05-25 17:01:01.731+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
05-25 17:01:01.731+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
05-25 17:01:01.731+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
05-25 17:01:01.731+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
05-25 17:01:01.741+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2650].
05-25 17:01:01.741+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(604734663)
05-25 17:01:01.741+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
05-25 17:01:01.741+0900 W/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-25 17:01:01.741+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
05-25 17:01:01.741+0900 I/HIGEAR  ( 3216): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
05-25 17:01:01.751+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_set_info(1442) > [3707.091077] layer(0x874fb8) not usable
05-25 17:01:01.751+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_set_info(1459) > [3707.091114] layer(0x874fb8) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
05-25 17:01:01.751+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_layer_set_info(1578) > [3707.091136] layer[0x874b08]zpos[1]
05-25 17:01:01.751+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_set_info(1442) > [3707.091196] layer(0x875008) not usable
05-25 17:01:01.751+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_set_info(1459) > [3707.091212] layer(0x875008) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
05-25 17:01:01.751+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_layer_set_info(1578) > [3707.091229] layer[0x874c28]zpos[2]
05-25 17:01:01.771+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
05-25 17:01:01.771+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
05-25 17:01:01.771+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: preference_get_boolean(1173) > preference_get_boolean(3233) : test_healthy_pace error
05-25 17:01:01.791+0900 W/SHealthCommon( 3233): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1495670400000.000000[0;m
05-25 17:01:01.811+0900 W/SHealthCommon( 3233): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.widget.hrlog (916859)]][0;m
05-25 17:01:01.841+0900 W/SHealthCommon( 3233): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.1.30][0;m
05-25 17:01:01.841+0900 W/SHealthWidget( 2843): WidgetMain.cpp: widget_update(147) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.widget.hrlog (916859), msgName: timeline_summary_updated[0;m
05-25 17:01:01.841+0900 W/SHealthCommon( 2843): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
05-25 17:01:01.841+0900 W/SHealthWidget( 2843): HrLogWidgetViewController.cpp: OnIpcProxyMessageReceived(71) > [1;35m##24Hour Widget Service SummaryUpdate Called[0;m
05-25 17:01:01.841+0900 W/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1495731661858.000000, pattern:[HH:mm][0;m
05-25 17:01:01.851+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-25 17:01:01.851+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-25 17:01:01.851+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-25 17:01:01.851+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-25 17:01:01.851+0900 E/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale ko_KR[0;m
05-25 17:01:01.851+0900 W/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:01][0;m
05-25 17:01:01.851+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-25 17:01:01.851+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-25 17:01:01.851+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-25 17:01:01.851+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-25 17:01:01.851+0900 I/CAPI_WIDGET_APPLICATION( 2843): widget_app.c: __provider_update_cb(281) > received updating signal
05-25 17:01:01.851+0900 I/HealthDataService( 2909): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-25 17:01:01.871+0900 I/healthData( 3233): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
05-25 17:01:01.921+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_disable_timer_cb(145) > timeout callback expired
05-25 17:01:01.921+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_enable(138) > 0
05-25 17:01:01.921+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
05-25 17:01:01.971+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
05-25 17:01:01.971+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-25 17:01:01.971+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 25-5-2017, 08:10:28 (UTC).
05-25 17:01:01.971+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-25 17:01:01.971+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
05-25 17:01:01.971+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: alarm_manager_alarm_delete(2460) > alarm_id[604734663] is removed.
05-25 17:01:01.981+0900 W/STARTER ( 2650): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [unknown]
05-25 17:01:01.981+0900 W/STARTER ( 2650): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[0]
05-25 17:01:02.671+0900 E/WMS     ( 2450): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23510) > _wms_event_handler_cb_nomove_detector is called
05-25 17:01:07.891+0900 E/WMS     ( 2450): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23510) > _wms_event_handler_cb_nomove_detector is called
05-25 17:01:08.261+0900 I/USR_TAG ( 9080): loud sound is detected!
05-25 17:01:08.631+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 9080 pgid = 9080
05-25 17:01:08.631+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
05-25 17:01:08.671+0900 W/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
05-25 17:01:08.671+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
05-25 17:01:08.671+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:01:08.671+0900 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2724] goes to (3)
05-25 17:01:08.671+0900 E/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2724)'s state(3)
05-25 17:01:08.671+0900 W/AUL_AMD ( 2490): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-25 17:01:08.671+0900 W/AUL_AMD ( 2490): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
05-25 17:01:08.671+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2724) status(fg) type(uiapp)
05-25 17:01:08.701+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
05-25 17:01:08.701+0900 I/AUL_AMD ( 2490): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 9080
05-25 17:01:08.701+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(9080)
05-25 17:01:08.721+0900 W/PROCESSMGR( 2318): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
05-25 17:01:08.721+0900 W/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
05-25 17:01:08.721+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
05-25 17:01:08.721+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:01:08.741+0900 W/W_HOME  ( 2724): event_manager.c: _ecore_x_message_cb(428) > state: 1 -> 0
05-25 17:01:08.741+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:01:08.741+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:01:08.751+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:01:08.751+0900 W/W_HOME  ( 2724): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
05-25 17:01:08.761+0900 W/W_HOME  ( 2724): event_manager.c: _window_visibility_cb(473) > Window [0x1E00003] is now visible(0)
05-25 17:01:08.761+0900 W/W_HOME  ( 2724): event_manager.c: _window_visibility_cb(483) > state: 0 -> 1
05-25 17:01:08.761+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:01:08.761+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:01:08.761+0900 W/W_HOME  ( 2724): main.c: _window_visibility_cb(964) > Window [0x1E00003] is now visible(0)
05-25 17:01:08.761+0900 I/APP_CORE( 2724): appcore-efl.c: __do_app(453) > [APP 2724] Event: RESUME State: PAUSED
05-25 17:01:08.761+0900 I/CAPI_APPFW_APPLICATION( 2724): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-25 17:01:08.761+0900 W/W_HOME  ( 2724): main.c: _appcore_resume_cb(479) > appcore resume
05-25 17:01:08.771+0900 W/W_HOME  ( 2724): event_manager.c: _app_resume_cb(380) > state: 2 -> 1
05-25 17:01:08.771+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:01:08.771+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:01:08.771+0900 W/W_HOME  ( 2724): main.c: home_resume(527) > journal_multimedia_screen_loaded_home called
05-25 17:01:08.771+0900 W/W_HOME  ( 2724): main.c: home_resume(531) > clock/widget resumed
05-25 17:01:08.771+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:01:08.771+0900 I/wnotib  ( 2724): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 0
05-25 17:01:08.771+0900 E/wnotib  ( 2724): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-25 17:01:08.771+0900 W/wnotib  ( 2724): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
05-25 17:01:08.791+0900 W/SHealthCommon( 2843): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_resumed, name: app_resumed][0;m
05-25 17:01:08.791+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-25 17:01:08.791+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-25 17:01:08.791+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-25 17:01:08.791+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-25 17:01:08.791+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
05-25 17:01:08.791+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-25 17:01:08.791+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
05-25 17:01:08.791+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-25 17:01:08.791+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-25 17:01:08.791+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:01:08.791+0900 I/CAPI_WIDGET_APPLICATION( 2843): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
05-25 17:01:08.791+0900 W/AUL     ( 2843): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.shealth.widget.pedometer) pid(2843) status(fg) type(widgetapp)
05-25 17:01:08.791+0900 I/CAPI_WIDGET_APPLICATION( 2843): widget_app.c: __check_status_for_cgroup(134) > enter foreground group
05-25 17:01:08.801+0900 W/CRASH_MANAGER( 9409): worker.c: worker_job(1199) > 1109080636c6f149569926

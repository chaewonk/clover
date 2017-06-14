S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.1
Build-Number: R760XXU1APL2
Build-Date: 2016.12.20 22:57:01

Crash Information
Process Name: clover
PID: 12421
Date: 2017-05-25 17:20:31+0900
Executable File Path: /opt/usr/apps/org.example.clover/bin/clover
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 12421, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0xf5c1a25c, r3   = 0x00000001
r4   = 0xf6fe29b8, r5   = 0xf6fe29b8
r6   = 0xf6fe216c, r7   = 0xff8d8ee0
r8   = 0xf6fe29b8, r9   = 0xf7868b80
r10  = 0xf6ff0b10, fp   = 0x00000000
ip   = 0xf5c1a29c, sp   = 0xff8d8e98
lr   = 0xf6da65d0, pc   = 0xf5c06562
cpsr = 0x60000030

Memory Information
MemTotal:   714608 KB
MemFree:     21188 KB
Buffers:     30868 KB
Cached:     166436 KB
VmPeak:     190420 KB
VmSize:     190416 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       37736 KB
VmRSS:       37732 KB
VmData:     112376 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       29384 KB
VmPTE:         188 KB
VmSwap:          0 KB

Threads Information
Threads: 11
PID = 12421 TID = 12421
12421 12533 12534 12538 12539 12540 12541 12542 12543 12544 12545 

Maps Information
ed055000 ed854000 rw-p [stack:12545]
ed855000 ee455000 rw-p [stack:12544]
ee456000 eec55000 rw-p [stack:12543]
eec56000 ef455000 rw-p [stack:12542]
efc58000 f0457000 rw-p [stack:12541]
f0458000 f0c57000 rw-p [stack:12540]
f0c57000 f0c5a000 r-xp /usr/lib/gstreamer-0.10/libgstwavenc.so
f0c62000 f0c7c000 r-xp /usr/lib/gstreamer-0.10/libgstpulse.so
f0c85000 f0cbd000 r-xp /usr/lib/libsamrnb.so
f0ce0000 f0ceb000 r-xp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
f0cf4000 f0d04000 r-xp /usr/lib/gstreamer-0.10/libgstalsa.so
f0d0c000 f0d12000 r-xp /usr/lib/libscmn.so
f0d1a000 f0d52000 r-xp /usr/lib/libsaac.so
f0d5c000 f0d61000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencamrnb.so
f0d69000 f0d79000 r-xp /usr/lib/lib_SamsungRec_TizenV04015.so
f0d9a000 f0da2000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
f0db1000 f0db6000 r-xp /usr/lib/gstreamer-0.10/libgstsecrecord.so
f0dc8000 f0de0000 r-xp /usr/lib/libgstcontroller-0.10.so.0.30.0
f0df0000 f0df6000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencaac.so
f0dfe000 f0e16000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
f0e1f000 f0e48000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
f0e5a000 f0e5f000 r-xp /usr/lib/gstreamer-0.10/libgstvolume.so
f0e67000 f0fc5000 r-xp /usr/lib/gstreamer-0.10/libgstffmpeg.so
f10ad000 f10b9000 r-xp /usr/lib/gstreamer-0.10/libgstencodebin.so
f10c1000 f10e1000 r-xp /usr/lib/gstreamer-0.10/libgstomx.so
f10e2000 f1116000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
f111f000 f112a000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
f1132000 f1134000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
f113c000 f113d000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
f1147000 f114a000 r-xp /usr/lib/gstreamer-0.10/libgstavsysaudiosrc.so
f1152000 f1153000 r-xp /usr/lib/gstreamer-0.10/libgstapp.so
f125a000 f1a59000 rw-p [stack:12534]
f1a5a000 f2259000 rw-p [stack:12533]
f2408000 f2410000 r-xp /usr/lib/libfeedback.so.0.1.4
f2413000 f2414000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
f241d000 f2c1c000 rw-p [stack:12538]
f2c1c000 f2c1d000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
f2d60000 f355f000 rw-p [stack:12539]
f355f000 f3561000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
f3569000 f3580000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f358d000 f3592000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f359a000 f35a5000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f38df000 f39d1000 r-xp /usr/lib/libCOREGL.so.4.0
f39ea000 f39ef000 r-xp /usr/lib/libsystem.so.0.0.0
f39f9000 f39fa000 r-xp /usr/lib/libresponse.so.0.2.96
f3a02000 f3a07000 r-xp /usr/lib/libproc-stat.so.0.2.96
f3a10000 f3a12000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f3a1a000 f3a21000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f3a2a000 f3a4c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f3a55000 f3a59000 r-xp /usr/lib/libogg.so.0.7.1
f3a61000 f3a83000 r-xp /usr/lib/libvorbis.so.0.4.3
f3a8b000 f3a8e000 r-xp /usr/lib/libtinycompress.so.0.0.0
f3a96000 f3aa5000 r-xp /usr/lib/libmdm-common.so.1.1.22
f3aae000 f3ab6000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f3abe000 f3ac4000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f3acd000 f3ad4000 r-xp /usr/lib/libminizip.so.1.0.0
f3adc000 f3ade000 r-xp /usr/lib/libttrace.so.1.1
f3ae6000 f3b2d000 r-xp /usr/lib/libsndfile.so.1.0.26
f3b39000 f3b82000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f3b8b000 f3b90000 r-xp /usr/lib/libjson.so.0.0.1
f5429000 f552f000 r-xp /usr/lib/libicuuc.so.57.1
f5545000 f56cd000 r-xp /usr/lib/libicui18n.so.57.1
f56dd000 f56ea000 r-xp /usr/lib/libail.so.0.1.0
f56f3000 f56f6000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f56fe000 f5701000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f5709000 f576a000 r-xp /usr/lib/libasound.so.2.0.0
f5774000 f578a000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f5792000 f5796000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f579e000 f57df000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
f57e8000 f57ea000 r-xp /usr/lib/libdri2.so.0.0.0
f57f2000 f57fa000 r-xp /usr/lib/libdrm.so.2.4.0
f5802000 f5808000 r-xp /usr/lib/libxcb-render.so.0.0.0
f5810000 f5811000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f581a000 f581e000 r-xp /usr/lib/libEGL.so.1.4
f582e000 f583f000 r-xp /usr/lib/libGLESv2.so.2.0
f584f000 f5897000 r-xp /usr/lib/libmdm.so.1.2.62
f5898000 f589f000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f58a7000 f58b2000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f58bf000 f58d8000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f58e0000 f58e5000 r-xp /usr/lib/libstorage.so.0.1
f58ed000 f58f2000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f58fa000 f5932000 r-xp /usr/lib/libpulse.so.0.16.2
f5933000 f5937000 r-xp /usr/lib/libmmfsession.so.0.0.0
f5940000 f5957000 r-xp /usr/lib/libmmfsound.so.0.1.0
f5969000 f598a000 r-xp /usr/lib/libexif.so.12.3.3
f599d000 f59a6000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
f59ae000 f59bb000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
f59c4000 f59cf000 r-xp /usr/lib/libtbm.so.1.0.0
f59d7000 f59dc000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f59e4000 f5a9c000 r-xp /usr/lib/libcairo.so.2.11200.14
f5aa7000 f5b42000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
f5b4e000 f5b9e000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
f5ba4000 f5bb6000 r-xp /usr/lib/libcapi-media-camera.so.0.1.35
f5bbe000 f5bdf000 r-xp /usr/lib/libefl-extension.so.0.1.0
f5be7000 f5bec000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5bf4000 f5bfc000 r-xp /usr/lib/libcapi-media-recorder.so.0.1.28
f5c04000 f5c0b000 r-xp /opt/usr/apps/org.example.clover/bin/clover
f5dad000 f5db7000 r-xp /lib/libnss_files-2.13.so
f5dc0000 f5e8f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f5ea5000 f5ec9000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f5ed2000 f5ed8000 r-xp /usr/lib/libappsvc.so.0.1.0
f5ee0000 f5ee2000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f5eeb000 f5eef000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f5efb000 f5f06000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f5f0e000 f5f10000 r-xp /usr/lib/libiniparser.so.0
f5f19000 f5f1e000 r-xp /usr/lib/libappcore-common.so.1.1
f5f26000 f5f28000 r-xp /usr/lib/libcamsrcjpegenc.so.0.0.0
f5f30000 f5f34000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f5f41000 f5f43000 r-xp /usr/lib/libXau.so.6.0.0
f5f4b000 f5f52000 r-xp /lib/libcrypt-2.13.so
f5f82000 f5f84000 r-xp /usr/lib/libiri.so
f5f8d000 f6136000 r-xp /usr/lib/libcrypto.so.1.0.0
f6156000 f619d000 r-xp /usr/lib/libssl.so.1.0.0
f61a9000 f61d7000 r-xp /usr/lib/libidn.so.11.5.44
f61df000 f61e8000 r-xp /usr/lib/libcares.so.2.1.0
f61f2000 f6205000 r-xp /usr/lib/libxcb.so.1.1.0
f620e000 f6210000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6218000 f621a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6223000 f62ef000 r-xp /usr/lib/libxml2.so.2.7.8
f62fc000 f62fe000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6307000 f630c000 r-xp /usr/lib/libffi.so.5.0.10
f6314000 f6315000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f631d000 f6320000 r-xp /lib/libattr.so.1.1.0
f6328000 f63bc000 r-xp /usr/lib/libstdc++.so.6.0.16
f63cf000 f63ec000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f63f6000 f640e000 r-xp /usr/lib/libpng12.so.0.50.0
f6416000 f642c000 r-xp /lib/libexpat.so.1.6.0
f6436000 f647a000 r-xp /usr/lib/libcurl.so.4.3.0
f6483000 f648d000 r-xp /usr/lib/libXext.so.6.4.0
f6496000 f649a000 r-xp /usr/lib/libXtst.so.6.1.0
f64a2000 f64a8000 r-xp /usr/lib/libXrender.so.1.3.0
f64b0000 f64b6000 r-xp /usr/lib/libXrandr.so.2.2.0
f64be000 f64bf000 r-xp /usr/lib/libXinerama.so.1.0.0
f64c8000 f64d1000 r-xp /usr/lib/libXi.so.6.1.0
f64d9000 f64dc000 r-xp /usr/lib/libXfixes.so.3.1.0
f64e4000 f64e6000 r-xp /usr/lib/libXgesture.so.7.0.0
f64ee000 f64f0000 r-xp /usr/lib/libXcomposite.so.1.0.0
f64f8000 f64fa000 r-xp /usr/lib/libXdamage.so.1.1.0
f6502000 f6509000 r-xp /usr/lib/libXcursor.so.1.0.2
f6511000 f6514000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f651c000 f6520000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f6529000 f652e000 r-xp /usr/lib/libecore_fb.so.1.7.99
f6537000 f6618000 r-xp /usr/lib/libX11.so.6.3.0
f6623000 f6646000 r-xp /usr/lib/libjpeg.so.8.0.2
f665e000 f6674000 r-xp /lib/libz.so.1.2.5
f667c000 f667e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6686000 f66fb000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6705000 f671f000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6727000 f675b000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6764000 f6837000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6842000 f6852000 r-xp /lib/libresolv-2.13.so
f6856000 f686e000 r-xp /usr/lib/liblzma.so.5.0.3
f6876000 f6879000 r-xp /lib/libcap.so.2.21
f6881000 f68b0000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f68b8000 f68b9000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f68c1000 f68c7000 r-xp /usr/lib/libecore_imf.so.1.7.99
f68cf000 f68e6000 r-xp /usr/lib/liblua-5.1.so
f68ef000 f68f6000 r-xp /usr/lib/libembryo.so.1.7.99
f68fe000 f6904000 r-xp /lib/librt-2.13.so
f690d000 f6963000 r-xp /usr/lib/libpixman-1.so.0.28.2
f6970000 f69c6000 r-xp /usr/lib/libfreetype.so.6.11.3
f69d2000 f69fa000 r-xp /usr/lib/libfontconfig.so.1.8.0
f69fb000 f6a40000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6a49000 f6a5c000 r-xp /usr/lib/libfribidi.so.0.3.1
f6a64000 f6a7e000 r-xp /usr/lib/libecore_con.so.1.7.99
f6a87000 f6a90000 r-xp /usr/lib/libedbus.so.1.7.99
f6a98000 f6ae8000 r-xp /usr/lib/libecore_x.so.1.7.99
f6aea000 f6af3000 r-xp /usr/lib/libvconf.so.0.2.45
f6afb000 f6b0c000 r-xp /usr/lib/libecore_input.so.1.7.99
f6b14000 f6b19000 r-xp /usr/lib/libecore_file.so.1.7.99
f6b21000 f6b43000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6b4c000 f6b8d000 r-xp /usr/lib/libeina.so.1.7.99
f6b96000 f6baf000 r-xp /usr/lib/libeet.so.1.7.99
f6bc0000 f6c29000 r-xp /lib/libm-2.13.so
f6c32000 f6c38000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c41000 f6c42000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c4a000 f6c6d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c75000 f6c7a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c82000 f6cac000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6cb5000 f6ccc000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6cd4000 f6cdf000 r-xp /lib/libunwind.so.8.0.1
f6d0c000 f6d2a000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d34000 f6e58000 r-xp /lib/libc-2.13.so
f6e66000 f6e6e000 r-xp /lib/libgcc_s-4.6.so.1
f6e6f000 f6e73000 r-xp /usr/lib/libsmack.so.1.0.0
f6e7c000 f6e82000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f6e8a000 f6f5a000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f5b000 f6fb9000 r-xp /usr/lib/libedje.so.1.7.99
f6fc3000 f6fda000 r-xp /usr/lib/libecore.so.1.7.99
f6ff1000 f70bf000 r-xp /usr/lib/libevas.so.1.7.99
f70e4000 f7220000 r-xp /usr/lib/libelementary.so.1.7.99
f7237000 f724b000 r-xp /lib/libpthread-2.13.so
f7256000 f7258000 r-xp /usr/lib/libdlog.so.0.0.0
f7260000 f7263000 r-xp /usr/lib/libbundle.so.0.1.22
f726b000 f726d000 r-xp /lib/libdl-2.13.so
f7276000 f7283000 r-xp /usr/lib/libaul.so.0.1.0
f7294000 f729a000 r-xp /usr/lib/libappcore-efl.so.1.1
f72a3000 f72a7000 r-xp /usr/lib/libsys-assert.so
f72b0000 f72cd000 r-xp /lib/ld-2.13.so
f72d6000 f72db000 r-xp /usr/bin/launchpad-loader
f7830000 f7c39000 rw-p [heap]
ff8b9000 ff8da000 rw-p [stack]
End of Maps Information

Callstack Information (PID:12421)
Call Stack Count: 12
 0: ecore_timer_cb + 0xc9 (0xf5c06562) [/opt/usr/apps/org.example.clover/bin/clover] + 0x2562
 1: (0xf6fd21f9) [/usr/lib/libecore.so.1] + 0xf1f9
 2: (0xf6fd22ef) [/usr/lib/libecore.so.1] + 0xf2ef
 3: (0xf6fcf2f3) [/usr/lib/libecore.so.1] + 0xc2f3
 4: ecore_main_loop_begin + 0x30 (0xf6fcf879) [/usr/lib/libecore.so.1] + 0xc879
 5: appcore_efl_main + 0x332 (0xf7297b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
 6: ui_app_main + 0xb0 (0xf5f32421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 7: uib_app_run + 0xea (0xf5c06f0b) [/opt/usr/apps/org.example.clover/bin/clover] + 0x2f0b
 8: main + 0x34 (0xf5c06489) [/opt/usr/apps/org.example.clover/bin/clover] + 0x2489
 9: (0xf72d7a53) [/opt/usr/apps/org.example.clover/bin/clover] + 0x1a53
10: __libc_start_main + 0x114 (0xf6d4b85c) [/lib/libc.so.6] + 0x1785c
11: (0xf72d7e0c) [/opt/usr/apps/org.example.clover/bin/clover] + 0x1e0c
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
 : -147223796[0;m
05-25 17:20:26.771+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
05-25 17:20:26.771+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-25 17:20:26.771+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
05-25 17:20:26.771+0900 W/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
05-25 17:20:26.771+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
05-25 17:20:26.781+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
05-25 17:20:26.781+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
05-25 17:20:26.781+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
05-25 17:20:26.791+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
05-25 17:20:26.791+0900 W/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-25 17:20:26.791+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
05-25 17:20:26.561+0900 W/SHealthCommon( 3233): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.widget.hrlog (916859)]][0;m
05-25 17:20:26.741+0900 W/W_HOME  ( 2724): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
05-25 17:20:26.741+0900 E/ALARM_MANAGER( 2443): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 495529361, next duetime: 1495700447
05-25 17:20:26.791+0900 I/HIGEAR  ( 3216): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
05-25 17:20:26.811+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(495529361)
05-25 17:20:26.811+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1495701458), due_time(1495700447)
05-25 17:20:26.871+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_disable_timer_cb(145) > timeout callback expired
05-25 17:20:26.871+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_enable(138) > 0
05-25 17:20:26.871+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
05-25 17:20:26.881+0900 W/SHealthCommon( 2843): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:1[0;m
05-25 17:20:26.891+0900 W/SHealthWidget( 2843): WidgetMain.cpp: widget_update(147) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.widget.hrlog (916859), msgName: timeline_summary_updated[0;m
05-25 17:20:26.891+0900 W/SHealthCommon( 2843): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
05-25 17:20:26.891+0900 W/SHealthWidget( 2843): HrLogWidgetViewController.cpp: OnIpcProxyMessageReceived(71) > [1;35m##24Hour Widget Service SummaryUpdate Called[0;m
05-25 17:20:26.901+0900 W/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1495732826909.000000, pattern:[HH:mm][0;m
05-25 17:20:26.901+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-25 17:20:26.901+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-25 17:20:26.901+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-25 17:20:26.901+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-25 17:20:26.901+0900 E/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale ko_KR[0;m
05-25 17:20:26.901+0900 W/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:20][0;m
05-25 17:20:26.901+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-25 17:20:26.901+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-25 17:20:26.901+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-25 17:20:26.901+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-25 17:20:26.901+0900 I/CAPI_WIDGET_APPLICATION( 2843): widget_app.c: __provider_update_cb(281) > received updating signal
05-25 17:20:26.931+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
05-25 17:20:26.941+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-25 17:20:26.941+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 25-5-2017, 08:20:47 (UTC).
05-25 17:20:26.941+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-25 17:20:26.941+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
05-25 17:20:26.951+0900 W/STARTER ( 2650): clock-mgr.c: _on_lcd_signal_receive_cb(1579) > [_on_lcd_signal_receive_cb:1579] _on_lcd_signal_receive_cb, 1579, Pre LCD on by [gesture] after screen off time [130]ms
05-25 17:20:26.951+0900 W/STARTER ( 2650): clock-mgr.c: _pre_lcd_on(1298) > [_pre_lcd_on:1298] Will LCD ON as reserved app[(null)] alpm mode[0]
05-25 17:20:26.951+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2650].
05-25 17:20:26.951+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(495529361)
05-25 17:20:26.961+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
05-25 17:20:26.961+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-25 17:20:26.961+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 25-5-2017, 08:37:38 (UTC).
05-25 17:20:26.961+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-25 17:20:26.971+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
05-25 17:20:26.971+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: alarm_manager_alarm_delete(2460) > alarm_id[495529361] is removed.
05-25 17:20:26.971+0900 W/STARTER ( 2650): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [gesture]
05-25 17:20:26.971+0900 W/STARTER ( 2650): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[0]
05-25 17:20:27.001+0900 E/weather-widget( 5156): WidgetMain.cpp: UpdateWidgetInstanceTimerCb(1138) > [0;40;31mUpdateWidgetInstanceTimerCb[0;m
05-25 17:20:27.011+0900 E/weather-widget( 5156): WidgetMain.cpp: LoadAllWeatherInformation(335) > [0;40;31mlastRefreshedTime:1495617447470, getLastRefreshedTime:1495617447470[0;m
05-25 17:20:27.011+0900 E/weather-widget( 5156): WidgetMain.cpp: UpdateWidgetInstanceTimerCb(1173) > [0;40;31mcontent is NULL[0;m
05-25 17:20:27.011+0900 E/weather-widget( 5156): WidgetMainView.cpp: Resume(3601) > [0;40;31mWidgetMainView::Resume[0;m
05-25 17:20:27.021+0900 W/LOCATION( 5156): location-common-util.c: location_is_onboard_gps_use_only(146) > onboard-gps-use-only mode: [0]
05-25 17:20:27.051+0900 W/SHealthCommon( 3233): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.1.30][0;m
05-25 17:20:27.081+0900 W/LOCATION( 5156): module-internal.c: module_is_supported(340) > module name(gps) is found
05-25 17:20:27.101+0900 W/SHealthCommon( 3233): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:1[0;m
05-25 17:20:27.121+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-25 17:20:27.131+0900 W/LOCATION( 5156): module-internal.c: module_is_supported(340) > module name(gps) is found
05-25 17:20:27.151+0900 W/LOCATION( 5156): module-internal.c: module_is_supported(340) > module name(wps) is found
05-25 17:20:27.151+0900 E/weather-common( 5156): Location.cpp: IsLocationEnabled(268) > [0;40;31menabled : 0[0;m
05-25 17:20:27.151+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-25 17:20:27.151+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: preference_get_double(1214) > preference_get_double(3233) : pedometer_inactive_period error
05-25 17:20:27.151+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-25 17:20:27.151+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-25 17:20:27.151+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: preference_get_double(1214) > preference_get_double(3233) : inactive_10min_precaution_millisec error
05-25 17:20:27.151+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-25 17:20:27.151+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-25 17:20:27.151+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: preference_get_double(1214) > preference_get_double(3233) : inactive_before_10min_precaution_millisec error
05-25 17:20:27.151+0900 E/weather-widget( 5156): WidgetViewData.cpp: GetWidgetLifeCycleEvent(1606) > [0;40;31mGetWidgetLifeCycleEvent, mWidgetLifeCycleEvent:4[0;m
05-25 17:20:27.161+0900 I/HealthDataService( 2909): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-25 17:20:27.171+0900 E/weather-widget( 5156): WidgetMainView.cpp: UpdateViewPage(719) > [0;40;31mUpdateViewPage locationId : 4111700000:CurrentCity[0;m
05-25 17:20:27.181+0900 W/LOCATION( 5156): location-common-util.c: location_is_onboard_gps_use_only(146) > onboard-gps-use-only mode: [0]
05-25 17:20:27.201+0900 W/LOCATION( 5156): module-internal.c: module_is_supported(340) > module name(gps) is found
05-25 17:20:27.221+0900 W/LOCATION( 5156): module-internal.c: module_is_supported(340) > module name(gps) is found
05-25 17:20:27.231+0900 W/LOCATION( 5156): module-internal.c: module_is_supported(340) > module name(wps) is found
05-25 17:20:27.231+0900 E/weather-common( 5156): Location.cpp: IsLocationEnabled(268) > [0;40;31menabled : 0[0;m
05-25 17:20:27.231+0900 E/weather-widget( 5156): WidgetViewData.cpp: GetWidgetLifeCycleEvent(1606) > [0;40;31mGetWidgetLifeCycleEvent, mWidgetLifeCycleEvent:4[0;m
05-25 17:20:27.261+0900 E/weather-widget( 5156): WidgetMainView.cpp: CreateExtraWeatherInfo(618) > [0;40;31m[CreateExtraWeatherInfo(): 618] (layout == NULL) [return][0;m
05-25 17:20:27.261+0900 W/LOCATION( 5156): location-common-util.c: location_is_onboard_gps_use_only(146) > onboard-gps-use-only mode: [0]
05-25 17:20:27.291+0900 W/LOCATION( 5156): module-internal.c: module_is_supported(340) > module name(gps) is found
05-25 17:20:27.311+0900 W/LOCATION( 5156): module-internal.c: module_is_supported(340) > module name(gps) is found
05-25 17:20:27.321+0900 I/healthData( 3233): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
05-25 17:20:27.331+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
05-25 17:20:27.331+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
05-25 17:20:27.331+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: preference_get_boolean(1173) > preference_get_boolean(3233) : test_healthy_pace error
05-25 17:20:27.331+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-25 17:20:27.331+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-25 17:20:27.331+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: preference_get_double(1214) > preference_get_double(3233) : pedometer_inactive_period error
05-25 17:20:27.331+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-25 17:20:27.331+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-25 17:20:27.331+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: preference_get_double(1214) > preference_get_double(3233) : inactive_10min_precaution_millisec error
05-25 17:20:27.331+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-25 17:20:27.331+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-25 17:20:27.331+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: preference_get_double(1214) > preference_get_double(3233) : inactive_before_10min_precaution_millisec error
05-25 17:20:27.341+0900 W/LOCATION( 5156): module-internal.c: module_is_supported(340) > module name(wps) is found
05-25 17:20:27.341+0900 E/weather-common( 5156): Location.cpp: IsLocationEnabled(268) > [0;40;31menabled : 0[0;m
05-25 17:20:27.341+0900 E/weather-widget( 5156): WidgetMain.cpp: CheckAndRequestAutoRefresh(814) > [0;40;31m[CheckAndRequestAutoRefresh(): 814] (location && location->IsLocationEnabled() == false) [break][0;m
05-25 17:20:27.351+0900 E/EFL     ( 5156): edje<5156> edje_util.c:3785 edje_object_size_min_restricted_calc() group highLowTemperature has a non-fixed part 'highTemp'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-25 17:20:27.351+0900 E/EFL     ( 5156): edje<5156> edje_util.c:3785 edje_object_size_min_restricted_calc() group widgetMainViewPage has a non-fixed part 'iconAndCurrentTempSwallow'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-25 17:20:27.551+0900 E/rpm-installer(12410): rpm-appcore-intf.c: main(273) > ------------------------------------------------
05-25 17:20:27.551+0900 E/rpm-installer(12410): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
05-25 17:20:27.551+0900 E/rpm-installer(12410): rpm-appcore-intf.c: main(275) > ------------------------------------------------
05-25 17:20:27.581+0900 E/PKGMGR_SERVER(12409): pkgmgr-server.c: sighandler(486) > child NORMAL exit [12410]
05-25 17:20:27.681+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-25 17:20:27.681+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-25 17:20:27.681+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-25 17:20:27.681+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-25 17:20:27.681+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-25 17:20:27.681+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-25 17:20:27.681+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-25 17:20:27.681+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:20:27.681+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-25 17:20:27.681+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-25 17:20:27.681+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-25 17:20:27.681+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-25 17:20:27.681+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
05-25 17:20:27.681+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-25 17:20:27.681+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-25 17:20:27.681+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-25 17:20:27.681+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-25 17:20:27.681+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:20:27.681+0900 E/CAPI_APPFW_APP_CONTROL( 2895): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-25 17:20:27.681+0900 W/MUSIC_CONTROL_SERVICE( 2895): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:2895]   [com.samsung.w-home]register msg port [true][0m
05-25 17:20:27.681+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 14
05-25 17:20:27.681+0900 W/AUL_AMD ( 2490): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 2724
05-25 17:20:27.691+0900 W/MUSIC_CONTROL_SERVICE( 2895): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:2895]   [MUSIC_PLAYER_EVENT][0m
05-25 17:20:27.691+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-25 17:20:27.691+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-25 17:20:27.691+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-25 17:20:27.691+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-25 17:20:27.691+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-25 17:20:27.691+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-25 17:20:27.691+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-25 17:20:27.691+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:20:27.691+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-25 17:20:27.691+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-25 17:20:27.691+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-25 17:20:27.691+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-25 17:20:27.691+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
05-25 17:20:27.691+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-25 17:20:27.691+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-25 17:20:27.691+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-25 17:20:27.691+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-25 17:20:27.691+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:20:27.691+0900 W/W_HOME  ( 2724): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-25 17:20:27.691+0900 E/W_HOME  ( 2724): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-25 17:20:27.701+0900 W/MUSIC_CONTROL_SERVICE( 2895): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:2895]   [MUSIC_PLAYER_EVENT][0m
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:20:27.701+0900 W/W_HOME  ( 2724): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-25 17:20:27.701+0900 E/W_HOME  ( 2724): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-25 17:20:27.701+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:20:28.141+0900 W/AUL     (12529): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.clover)
05-25 17:20:28.141+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 0
05-25 17:20:28.151+0900 I/AUL_AMD ( 2490): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
05-25 17:20:28.161+0900 I/AUL_AMD ( 2490): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
05-25 17:20:28.161+0900 E/AUL_AMD ( 2490): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
05-25 17:20:28.161+0900 W/AUL_AMD ( 2490): amd_launch.c: _start_app(1782) > caller pid : 12529
05-25 17:20:28.181+0900 E/RESOURCED( 2613): block.c: block_prelaunch_state(138) > insert data org.example.clover, table num : 3
05-25 17:20:28.181+0900 W/AUL_AMD ( 2490): amd_launch.c: _start_app(2218) > pad pid(-5)
05-25 17:20:28.181+0900 W/AUL_PAD ( 3264): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
05-25 17:20:28.181+0900 W/AUL_PAD ( 3264): launchpad.c: __send_result_to_caller(272) > Check app launching
05-25 17:20:28.181+0900 W/AUL_PAD (12421): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
05-25 17:20:28.181+0900 W/AUL_PAD (12421): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
05-25 17:20:28.181+0900 W/AUL_PAD (12421): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
05-25 17:20:28.181+0900 W/AUL_PAD (12421): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.clover)
05-25 17:20:28.231+0900 I/efl-extension(12421): efl_extension.c: eext_mod_init(40) > Init
05-25 17:20:28.231+0900 W/AUL_PAD (12421): launchpad_loader.c: main(690) > [candidate] dlsym
05-25 17:20:28.231+0900 W/AUL_PAD (12421): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.clover)
05-25 17:20:28.231+0900 I/CAPI_APPFW_APPLICATION(12421): app_main.c: ui_app_main(704) > app_efl_main
05-25 17:20:28.241+0900 I/CAPI_APPFW_APPLICATION(12421): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-25 17:20:28.281+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.clover) pid(12421) type(uiapp) bg(0)
05-25 17:20:28.281+0900 W/AUL_AMD ( 2490): amd_status.c: __socket_monitor_cb(1277) > (12421) was created
05-25 17:20:28.281+0900 W/AUL     (12529): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12421)
05-25 17:20:28.291+0900 W/STARTER ( 2650): pkg-monitor.c: _app_mgr_status_cb(394) > [_app_mgr_status_cb:394] Launch request [12421]
05-25 17:20:28.361+0900 W/W_HOME  ( 2724): event_manager.c: _ecore_x_message_cb(428) > state: 0 -> 1
05-25 17:20:28.361+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:20:28.361+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:20:28.371+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:20:28.371+0900 W/W_HOME  ( 2724): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 0
05-25 17:20:28.371+0900 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
05-25 17:20:28.371+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
05-25 17:20:28.371+0900 E/EFL     (12421): ecore_evas<12421> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-25 17:20:28.431+0900 E/EFL     (12421): elementary<12421> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
05-25 17:20:28.451+0900 E/EFL     (12421): elementary<12421> elc_naviframe.c:2950 elm_naviframe_item_push() item(0xf799fef8) will be pushed
05-25 17:20:28.481+0900 E/TIZEN_N_RECORDER(12421): recorder.c: __convert_recorder_error_code(193) > [audio-channel] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:20:28.481+0900 E/TIZEN_N_RECORDER(12421): recorder.c: __convert_recorder_error_code(193) > [audio-device] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:20:28.481+0900 I/APP_CORE(12421): appcore-efl.c: __do_app(453) > [APP 12421] Event: RESET State: CREATED
05-25 17:20:28.481+0900 I/CAPI_APPFW_APPLICATION(12421): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-25 17:20:28.491+0900 I/APP_CORE(12421): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
05-25 17:20:28.491+0900 I/APP_CORE(12421): appcore-efl.c: __do_app(524) > [APP 12421] Initial Launching, call the resume_cb
05-25 17:20:28.491+0900 I/CAPI_APPFW_APPLICATION(12421): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-25 17:20:28.501+0900 W/APP_CORE(12421): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3600002
05-25 17:20:28.511+0900 I/AUL     (12434): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
05-25 17:20:28.531+0900 I/AUL     (12434): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:20:28.531+0900 E/AUL     (12434): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:20:28.531+0900 E/AUL     (12434): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:20:28.551+0900 W/W_HOME  ( 2724): event_manager.c: _window_visibility_cb(473) > Window [0x1E00003] is now visible(1)
05-25 17:20:28.551+0900 W/W_HOME  ( 2724): event_manager.c: _window_visibility_cb(483) > state: 1 -> 0
05-25 17:20:28.551+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:20:28.551+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:20:28.551+0900 W/W_HOME  ( 2724): main.c: _window_visibility_cb(964) > Window [0x1E00003] is now visible(1)
05-25 17:20:28.551+0900 I/APP_CORE(12421): appcore-efl.c: __do_app(453) > [APP 12421] Event: RESUME State: RUNNING
05-25 17:20:28.551+0900 I/APP_CORE( 2724): appcore-efl.c: __do_app(453) > [APP 2724] Event: PAUSE State: RUNNING
05-25 17:20:28.551+0900 I/CAPI_APPFW_APPLICATION( 2724): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-25 17:20:28.551+0900 W/W_HOME  ( 2724): main.c: _appcore_pause_cb(488) > appcore pause
05-25 17:20:28.551+0900 W/W_HOME  ( 2724): event_manager.c: _app_pause_cb(397) > state: 1 -> 2
05-25 17:20:28.551+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:20:28.561+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:20:28.561+0900 W/W_HOME  ( 2724): main.c: home_pause(547) > clock/widget paused
05-25 17:20:28.561+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:20:28.561+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-25 17:20:28.561+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-25 17:20:28.561+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-25 17:20:28.561+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-25 17:20:28.561+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-25 17:20:28.561+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-25 17:20:28.561+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-25 17:20:28.561+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:20:28.561+0900 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
05-25 17:20:28.561+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
05-25 17:20:28.561+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-25 17:20:28.561+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-25 17:20:28.561+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-25 17:20:28.561+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-25 17:20:28.561+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
05-25 17:20:28.561+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-25 17:20:28.561+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-25 17:20:28.561+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-25 17:20:28.561+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-25 17:20:28.561+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:20:28.561+0900 E/CAPI_APPFW_APP_CONTROL( 2895): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-25 17:20:28.561+0900 W/MUSIC_CONTROL_SERVICE( 2895): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:2895]   [com.samsung.w-home]register msg port [false][0m
05-25 17:20:28.561+0900 I/wnotib  ( 2724): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
05-25 17:20:28.561+0900 E/wnotib  ( 2724): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-25 17:20:28.561+0900 W/wnotib  ( 2724): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [3], notiboard card appending count [9].
05-25 17:20:28.571+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2724) status(bg) type(uiapp)
05-25 17:20:28.571+0900 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2724] goes to (4)
05-25 17:20:28.571+0900 E/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2724)'s state(4)
05-25 17:20:28.581+0900 E/weather-widget( 5156): WidgetMain.cpp: PauseWidgetInstance(1061) > [0;40;31mPauseWidgetInstance[0;m
05-25 17:20:28.581+0900 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[12421] goes to (3)
05-25 17:20:28.581+0900 W/AUL_AMD ( 2490): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-25 17:20:28.581+0900 W/AUL_AMD ( 2490): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
05-25 17:20:28.581+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.clover) pid(12421) status(fg) type(uiapp)
05-25 17:20:28.591+0900 E/weather-widget( 5156): WidgetMainView.cpp: HideActivityIndicator(1064) > [0;40;31m[HideActivityIndicator(): 1064] (refreshButtonLayout == NULL) [return][0;m
05-25 17:20:28.591+0900 E/weather-widget( 5156): WidgetMainView.cpp: Pause(3539) > [0;40;31mOnClosed[0;m
05-25 17:20:28.591+0900 E/weather-widget( 5156): WidgetMainView.cpp: LableSlidingStop(3460) > [0;40;31m[LableSlidingStop(): 3460] (!extraWeatherInfoLayout) [return][0;m
05-25 17:20:28.591+0900 E/weather-widget( 5156): WidgetMain.cpp: DeleteUpdateTimerData(276) > [0;40;31m[DeleteUpdateTimerData(): 276] (size < 1) [return][0;m
05-25 17:20:28.601+0900 E/weather-widget( 5156): WidgetMain.cpp: PauseWidgetInstance(1092) > [0;40;31mlocationID : 4111700000:CurrentCity[0;m
05-25 17:20:28.601+0900 I/CAPI_WIDGET_APPLICATION( 5156): widget_app.c: __provider_pause_cb(298) > widget obj was paused
05-25 17:20:28.601+0900 W/AUL     ( 5156): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.weather-widget) pid(5156) status(bg) type(widgetapp)
05-25 17:20:28.601+0900 I/CAPI_WIDGET_APPLICATION( 5156): widget_app.c: __check_status_for_cgroup(145) > enter background group
05-25 17:20:28.661+0900 E/PKGMGR_SERVER(12409): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=1, queue_status=1] 
05-25 17:20:28.661+0900 E/PKGMGR_SERVER(12409): pkgmgr-server.c: main(2281) > package manager server terminated.
05-25 17:20:28.941+0900 E/AUL     ( 2490): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
05-25 17:20:29.071+0900 I/APP_CORE( 2724): appcore-efl.c: __do_app(453) > [APP 2724] Event: MEM_FLUSH State: PAUSED
05-25 17:20:29.381+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 14
05-25 17:20:29.391+0900 W/AUL_AMD ( 2490): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12421
05-25 17:20:29.391+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 12
05-25 17:20:29.401+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 14
05-25 17:20:29.411+0900 W/AUL_AMD ( 2490): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12421
05-25 17:20:29.411+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 12
05-25 17:20:29.601+0900 I/AUL_PAD (12537): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
05-25 17:20:29.891+0900 E/EFL     (12421): ecore_x<12421> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=4875234 button=1
05-25 17:20:30.051+0900 E/EFL     (12421): ecore_x<12421> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=4875389 button=1
05-25 17:20:30.121+0900 I/USR_TAG (12421): record_start
05-25 17:20:30.121+0900 E/TIZEN_N_RECORDER(12421): recorder.c: __convert_recorder_error_code(193) > [recorder_attr_set_time_limit] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:20:30.131+0900 E/TIZEN_N_RECORDER(12421): recorder.c: __convert_recorder_error_code(193) > [recorder_set_filename] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:20:30.131+0900 E/TIZEN_N_RECORDER(12421): recorder.c: __convert_recorder_error_code(193) > [file-format] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:20:30.131+0900 E/TIZEN_N_RECORDER(12421): recorder.c: __convert_recorder_error_code(193) > [audio-encoder] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:20:30.431+0900 E/TIZEN_N_RECORDER(12421): recorder.c: __convert_recorder_error_code(193) > [recorder_start] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:20:30.431+0900 E/EFL     (12421): <12421> elm_main.c:1300 elm_object_disabled_set() safety check failed: obj == NULL
05-25 17:20:30.431+0900 E/EFL     (12421): <12421> elm_main.c:1300 elm_object_disabled_set() safety check failed: obj == NULL
05-25 17:20:30.441+0900 E/EFL     (12421): elementary<12421> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
05-25 17:20:30.451+0900 E/EFL     (12421): elementary<12421> elc_naviframe.c:2950 elm_naviframe_item_push() item(0xf230c0d8) will be pushed
05-25 17:20:30.471+0900 E/EFL     (12421): elementary<12421> elc_naviframe.c:2796 _push_transition_cb() item(0xf230c0d8) will transition
05-25 17:20:30.901+0900 E/EFL     (12421): elementary<12421> elc_naviframe.c:1193 _on_item_push_finished() item(0xf799fef8) transition finished
05-25 17:20:30.901+0900 E/EFL     (12421): elementary<12421> elc_naviframe.c:1218 _on_item_show_finished() item(0xf230c0d8) transition finished
05-25 17:20:31.061+0900 E/EFL     ( 2318): ecore_x<2318> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x3600002 time=4875810
05-25 17:20:31.061+0900 E/EFL     (12421): ecore_x<12421> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=4875810
05-25 17:20:31.061+0900 E/EFL     ( 2318): ecore_x<2318> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=4875810
05-25 17:20:31.341+0900 I/USR_TAG (12421): loud sound is detected!
05-25 17:20:31.701+0900 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2724] goes to (3)
05-25 17:20:31.701+0900 E/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2724)'s state(3)
05-25 17:20:31.701+0900 W/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
05-25 17:20:31.701+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
05-25 17:20:31.701+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:20:31.701+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 12421 pgid = 12421
05-25 17:20:31.701+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
05-25 17:20:31.701+0900 W/AUL_AMD ( 2490): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-25 17:20:31.701+0900 W/AUL_AMD ( 2490): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
05-25 17:20:31.701+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2724) status(fg) type(uiapp)
05-25 17:20:31.781+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
05-25 17:20:31.791+0900 I/AUL_AMD ( 2490): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 12421
05-25 17:20:31.791+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(12421)
05-25 17:20:31.821+0900 W/PROCESSMGR( 2318): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
05-25 17:20:31.831+0900 W/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
05-25 17:20:31.831+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
05-25 17:20:31.831+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:20:31.841+0900 W/CRASH_MANAGER(12552): worker.c: worker_job(1199) > 1112421636c6f149570043

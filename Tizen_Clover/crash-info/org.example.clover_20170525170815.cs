S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.1
Build-Number: R760XXU1APL2
Build-Date: 2016.12.20 22:57:01

Crash Information
Process Name: clover
PID: 10255
Date: 2017-05-25 17:08:15+0900
Executable File Path: /opt/usr/apps/org.example.clover/bin/clover
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 10255, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0xf5de826c, r3   = 0x00000001
r4   = 0xf71b09b8, r5   = 0xf71b09b8
r6   = 0xf71b016c, r7   = 0xfff97e40
r8   = 0xf71b09b8, r9   = 0xf7bccb80
r10  = 0xf71beb10, fp   = 0x00000000
ip   = 0xf5de82ac, sp   = 0xfff97df8
lr   = 0xf6f745d0, pc   = 0xf5dd4562
cpsr = 0x60000030

Memory Information
MemTotal:   714608 KB
MemFree:      7940 KB
Buffers:     34316 KB
Cached:     173116 KB
VmPeak:     189056 KB
VmSize:     189052 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       37232 KB
VmRSS:       37228 KB
VmData:     111012 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       29384 KB
VmPTE:         188 KB
VmSwap:          0 KB

Threads Information
Threads: 11
PID = 10255 TID = 10255
10255 10346 10347 10349 10350 10351 10352 10353 10354 10355 10356 

Maps Information
ed225000 eda24000 rw-p [stack:10356]
eda25000 ee625000 rw-p [stack:10355]
ee626000 eee25000 rw-p [stack:10354]
eee26000 ef625000 rw-p [stack:10353]
efe28000 f0627000 rw-p [stack:10352]
f0628000 f0e27000 rw-p [stack:10351]
f0e27000 f0e2a000 r-xp /usr/lib/gstreamer-0.10/libgstwavenc.so
f0e32000 f0e4c000 r-xp /usr/lib/gstreamer-0.10/libgstpulse.so
f0e55000 f0e8d000 r-xp /usr/lib/libsamrnb.so
f0eb0000 f0ebb000 r-xp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
f0ec4000 f0ed4000 r-xp /usr/lib/gstreamer-0.10/libgstalsa.so
f0edc000 f0ee2000 r-xp /usr/lib/libscmn.so
f0eea000 f0f22000 r-xp /usr/lib/libsaac.so
f0f2c000 f0f31000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencamrnb.so
f0f39000 f0f49000 r-xp /usr/lib/lib_SamsungRec_TizenV04015.so
f0f6a000 f0f72000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
f0f81000 f0f86000 r-xp /usr/lib/gstreamer-0.10/libgstsecrecord.so
f0f98000 f0fb0000 r-xp /usr/lib/libgstcontroller-0.10.so.0.30.0
f0fc0000 f0fc6000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencaac.so
f0fce000 f0fe6000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
f0fef000 f1018000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
f102a000 f102f000 r-xp /usr/lib/gstreamer-0.10/libgstvolume.so
f1037000 f1195000 r-xp /usr/lib/gstreamer-0.10/libgstffmpeg.so
f127d000 f1289000 r-xp /usr/lib/gstreamer-0.10/libgstencodebin.so
f1291000 f12b1000 r-xp /usr/lib/gstreamer-0.10/libgstomx.so
f12b2000 f12e6000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
f12ef000 f12fa000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
f1401000 f1c00000 rw-p [stack:10347]
f1c01000 f2400000 rw-p [stack:10346]
f2506000 f2508000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
f2510000 f2511000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
f2519000 f2521000 r-xp /usr/lib/libfeedback.so.0.1.4
f2526000 f2529000 r-xp /usr/lib/gstreamer-0.10/libgstavsysaudiosrc.so
f2531000 f2532000 r-xp /usr/lib/gstreamer-0.10/libgstapp.so
f253a000 f253b000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
f25eb000 f2dea000 rw-p [stack:10349]
f2dea000 f2deb000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
f2f2e000 f372d000 rw-p [stack:10350]
f372d000 f372f000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
f3737000 f374e000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f375b000 f3760000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f3768000 f3773000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f3aad000 f3b9f000 r-xp /usr/lib/libCOREGL.so.4.0
f3bb8000 f3bbd000 r-xp /usr/lib/libsystem.so.0.0.0
f3bc7000 f3bc8000 r-xp /usr/lib/libresponse.so.0.2.96
f3bd0000 f3bd5000 r-xp /usr/lib/libproc-stat.so.0.2.96
f3bde000 f3be0000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f3be8000 f3bef000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f3bf8000 f3c1a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f3c23000 f3c27000 r-xp /usr/lib/libogg.so.0.7.1
f3c2f000 f3c51000 r-xp /usr/lib/libvorbis.so.0.4.3
f3c59000 f3c5c000 r-xp /usr/lib/libtinycompress.so.0.0.0
f3c64000 f3c73000 r-xp /usr/lib/libmdm-common.so.1.1.22
f3c7c000 f3c84000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f3c8c000 f3c92000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f3c9b000 f3ca2000 r-xp /usr/lib/libminizip.so.1.0.0
f3caa000 f3cac000 r-xp /usr/lib/libttrace.so.1.1
f3cb4000 f3cfb000 r-xp /usr/lib/libsndfile.so.1.0.26
f3d07000 f3d50000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f3d59000 f3d5e000 r-xp /usr/lib/libjson.so.0.0.1
f55f7000 f56fd000 r-xp /usr/lib/libicuuc.so.57.1
f5713000 f589b000 r-xp /usr/lib/libicui18n.so.57.1
f58ab000 f58b8000 r-xp /usr/lib/libail.so.0.1.0
f58c1000 f58c4000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f58cc000 f58cf000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f58d7000 f5938000 r-xp /usr/lib/libasound.so.2.0.0
f5942000 f5958000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f5960000 f5964000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f596c000 f59ad000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
f59b6000 f59b8000 r-xp /usr/lib/libdri2.so.0.0.0
f59c0000 f59c8000 r-xp /usr/lib/libdrm.so.2.4.0
f59d0000 f59d6000 r-xp /usr/lib/libxcb-render.so.0.0.0
f59de000 f59df000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f59e8000 f59ec000 r-xp /usr/lib/libEGL.so.1.4
f59fc000 f5a0d000 r-xp /usr/lib/libGLESv2.so.2.0
f5a1d000 f5a65000 r-xp /usr/lib/libmdm.so.1.2.62
f5a66000 f5a6d000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f5a75000 f5a80000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f5a8d000 f5aa6000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f5aae000 f5ab3000 r-xp /usr/lib/libstorage.so.0.1
f5abb000 f5ac0000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f5ac8000 f5b00000 r-xp /usr/lib/libpulse.so.0.16.2
f5b01000 f5b05000 r-xp /usr/lib/libmmfsession.so.0.0.0
f5b0e000 f5b25000 r-xp /usr/lib/libmmfsound.so.0.1.0
f5b37000 f5b58000 r-xp /usr/lib/libexif.so.12.3.3
f5b6b000 f5b74000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
f5b7c000 f5b89000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
f5b92000 f5b9d000 r-xp /usr/lib/libtbm.so.1.0.0
f5ba5000 f5baa000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f5bb2000 f5c6a000 r-xp /usr/lib/libcairo.so.2.11200.14
f5c75000 f5d10000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
f5d1c000 f5d6c000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
f5d72000 f5d84000 r-xp /usr/lib/libcapi-media-camera.so.0.1.35
f5d8c000 f5dad000 r-xp /usr/lib/libefl-extension.so.0.1.0
f5db5000 f5dba000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5dc2000 f5dca000 r-xp /usr/lib/libcapi-media-recorder.so.0.1.28
f5dd2000 f5dd9000 r-xp /opt/usr/apps/org.example.clover/bin/clover
f5f7b000 f5f85000 r-xp /lib/libnss_files-2.13.so
f5f8e000 f605d000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f6073000 f6097000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f60a0000 f60a6000 r-xp /usr/lib/libappsvc.so.0.1.0
f60ae000 f60b0000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f60b9000 f60bd000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f60c9000 f60d4000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f60dc000 f60de000 r-xp /usr/lib/libiniparser.so.0
f60e7000 f60ec000 r-xp /usr/lib/libappcore-common.so.1.1
f60f4000 f60f6000 r-xp /usr/lib/libcamsrcjpegenc.so.0.0.0
f60fe000 f6102000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f610f000 f6111000 r-xp /usr/lib/libXau.so.6.0.0
f6119000 f6120000 r-xp /lib/libcrypt-2.13.so
f6150000 f6152000 r-xp /usr/lib/libiri.so
f615b000 f6304000 r-xp /usr/lib/libcrypto.so.1.0.0
f6324000 f636b000 r-xp /usr/lib/libssl.so.1.0.0
f6377000 f63a5000 r-xp /usr/lib/libidn.so.11.5.44
f63ad000 f63b6000 r-xp /usr/lib/libcares.so.2.1.0
f63c0000 f63d3000 r-xp /usr/lib/libxcb.so.1.1.0
f63dc000 f63de000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f63e6000 f63e8000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f63f1000 f64bd000 r-xp /usr/lib/libxml2.so.2.7.8
f64ca000 f64cc000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f64d5000 f64da000 r-xp /usr/lib/libffi.so.5.0.10
f64e2000 f64e3000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f64eb000 f64ee000 r-xp /lib/libattr.so.1.1.0
f64f6000 f658a000 r-xp /usr/lib/libstdc++.so.6.0.16
f659d000 f65ba000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f65c4000 f65dc000 r-xp /usr/lib/libpng12.so.0.50.0
f65e4000 f65fa000 r-xp /lib/libexpat.so.1.6.0
f6604000 f6648000 r-xp /usr/lib/libcurl.so.4.3.0
f6651000 f665b000 r-xp /usr/lib/libXext.so.6.4.0
f6664000 f6668000 r-xp /usr/lib/libXtst.so.6.1.0
f6670000 f6676000 r-xp /usr/lib/libXrender.so.1.3.0
f667e000 f6684000 r-xp /usr/lib/libXrandr.so.2.2.0
f668c000 f668d000 r-xp /usr/lib/libXinerama.so.1.0.0
f6696000 f669f000 r-xp /usr/lib/libXi.so.6.1.0
f66a7000 f66aa000 r-xp /usr/lib/libXfixes.so.3.1.0
f66b2000 f66b4000 r-xp /usr/lib/libXgesture.so.7.0.0
f66bc000 f66be000 r-xp /usr/lib/libXcomposite.so.1.0.0
f66c6000 f66c8000 r-xp /usr/lib/libXdamage.so.1.1.0
f66d0000 f66d7000 r-xp /usr/lib/libXcursor.so.1.0.2
f66df000 f66e2000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f66ea000 f66ee000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f66f7000 f66fc000 r-xp /usr/lib/libecore_fb.so.1.7.99
f6705000 f67e6000 r-xp /usr/lib/libX11.so.6.3.0
f67f1000 f6814000 r-xp /usr/lib/libjpeg.so.8.0.2
f682c000 f6842000 r-xp /lib/libz.so.1.2.5
f684a000 f684c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6854000 f68c9000 r-xp /usr/lib/libsqlite3.so.0.8.6
f68d3000 f68ed000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f68f5000 f6929000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6932000 f6a05000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a10000 f6a20000 r-xp /lib/libresolv-2.13.so
f6a24000 f6a3c000 r-xp /usr/lib/liblzma.so.5.0.3
f6a44000 f6a47000 r-xp /lib/libcap.so.2.21
f6a4f000 f6a7e000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6a86000 f6a87000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f6a8f000 f6a95000 r-xp /usr/lib/libecore_imf.so.1.7.99
f6a9d000 f6ab4000 r-xp /usr/lib/liblua-5.1.so
f6abd000 f6ac4000 r-xp /usr/lib/libembryo.so.1.7.99
f6acc000 f6ad2000 r-xp /lib/librt-2.13.so
f6adb000 f6b31000 r-xp /usr/lib/libpixman-1.so.0.28.2
f6b3e000 f6b94000 r-xp /usr/lib/libfreetype.so.6.11.3
f6ba0000 f6bc8000 r-xp /usr/lib/libfontconfig.so.1.8.0
f6bc9000 f6c0e000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6c17000 f6c2a000 r-xp /usr/lib/libfribidi.so.0.3.1
f6c32000 f6c4c000 r-xp /usr/lib/libecore_con.so.1.7.99
f6c55000 f6c5e000 r-xp /usr/lib/libedbus.so.1.7.99
f6c66000 f6cb6000 r-xp /usr/lib/libecore_x.so.1.7.99
f6cb8000 f6cc1000 r-xp /usr/lib/libvconf.so.0.2.45
f6cc9000 f6cda000 r-xp /usr/lib/libecore_input.so.1.7.99
f6ce2000 f6ce7000 r-xp /usr/lib/libecore_file.so.1.7.99
f6cef000 f6d11000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6d1a000 f6d5b000 r-xp /usr/lib/libeina.so.1.7.99
f6d64000 f6d7d000 r-xp /usr/lib/libeet.so.1.7.99
f6d8e000 f6df7000 r-xp /lib/libm-2.13.so
f6e00000 f6e06000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e0f000 f6e10000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e18000 f6e3b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e43000 f6e48000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e50000 f6e7a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e83000 f6e9a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ea2000 f6ead000 r-xp /lib/libunwind.so.8.0.1
f6eda000 f6ef8000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f02000 f7026000 r-xp /lib/libc-2.13.so
f7034000 f703c000 r-xp /lib/libgcc_s-4.6.so.1
f703d000 f7041000 r-xp /usr/lib/libsmack.so.1.0.0
f704a000 f7050000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f7058000 f7128000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7129000 f7187000 r-xp /usr/lib/libedje.so.1.7.99
f7191000 f71a8000 r-xp /usr/lib/libecore.so.1.7.99
f71bf000 f728d000 r-xp /usr/lib/libevas.so.1.7.99
f72b2000 f73ee000 r-xp /usr/lib/libelementary.so.1.7.99
f7405000 f7419000 r-xp /lib/libpthread-2.13.so
f7424000 f7426000 r-xp /usr/lib/libdlog.so.0.0.0
f742e000 f7431000 r-xp /usr/lib/libbundle.so.0.1.22
f7439000 f743b000 r-xp /lib/libdl-2.13.so
f7444000 f7451000 r-xp /usr/lib/libaul.so.0.1.0
f7462000 f7468000 r-xp /usr/lib/libappcore-efl.so.1.1
f7471000 f7475000 r-xp /usr/lib/libsys-assert.so
f747e000 f749b000 r-xp /lib/ld-2.13.so
f74a4000 f74a9000 r-xp /usr/bin/launchpad-loader
f7b94000 f7d46000 rw-p [heap]
fff78000 fff99000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10255)
Call Stack Count: 12
 0: ecore_timer_cb + 0xc9 (0xf5dd4562) [/opt/usr/apps/org.example.clover/bin/clover] + 0x2562
 1: (0xf71a01f9) [/usr/lib/libecore.so.1] + 0xf1f9
 2: (0xf71a02ef) [/usr/lib/libecore.so.1] + 0xf2ef
 3: (0xf719d2f3) [/usr/lib/libecore.so.1] + 0xc2f3
 4: ecore_main_loop_begin + 0x30 (0xf719d879) [/usr/lib/libecore.so.1] + 0xc879
 5: appcore_efl_main + 0x332 (0xf7465b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
 6: ui_app_main + 0xb0 (0xf6100421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 7: uib_app_run + 0xea (0xf5dd4ef3) [/opt/usr/apps/org.example.clover/bin/clover] + 0x2ef3
 8: main + 0x34 (0xf5dd4489) [/opt/usr/apps/org.example.clover/bin/clover] + 0x2489
 9: (0xf74a5a53) [/opt/usr/apps/org.example.clover/bin/clover] + 0x1a53
10: __libc_start_main + 0x114 (0xf6f1985c) [/lib/libc.so.6] + 0x1785c
11: (0xf74a5e0c) [/opt/usr/apps/org.example.clover/bin/clover] + 0x1e0c
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
IpcServer::SendResponse
05-25 17:07:54.761+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:07:54.761+0900 W/W_HOME  ( 2724): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-25 17:07:54.761+0900 E/W_HOME  ( 2724): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-25 17:07:54.761+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-25 17:07:54.761+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-25 17:07:54.761+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-25 17:07:54.761+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-25 17:07:54.761+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-25 17:07:54.761+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-25 17:07:54.761+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-25 17:07:54.761+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:07:54.761+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-25 17:07:54.761+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-25 17:07:54.761+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-25 17:07:54.761+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-25 17:07:54.761+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
05-25 17:07:54.761+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-25 17:07:54.761+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-25 17:07:54.761+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-25 17:07:54.761+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-25 17:07:54.761+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:07:54.791+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:07:54.991+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:07:55.011+0900 I/AUL_PAD (10255): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
05-25 17:07:55.191+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:07:55.231+0900 I/efl-extension(10256): efl_extension.c: eext_mod_init(40) > Init
05-25 17:07:55.391+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:07:55.501+0900 I/UXT     (10256): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
05-25 17:07:55.571+0900 I/AUL_PAD (10256): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
05-25 17:07:55.591+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:07:55.611+0900 E/MALI    (10256): mali_egl_winsys.c: window_surface_new(889) >  Create Window, it runs with MALI_X11_ASYNC_PAGEFLIP 1 
05-25 17:07:55.791+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:07:55.791+0900 E/PKGMGR_OBSERVER(10246): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[102460002] pkg_type[tpk] pkgid[org.example.clover] key[end] val[ok]
05-25 17:07:55.801+0900 W/W_HOME  ( 2724): clock_event.c: _pkgmgr_event_cb(247) > Pkg:org.example.clover is updated, need to check validation
05-25 17:07:55.801+0900 W/W_HOME  ( 2724): clock_event.c: _pkgmgr_event_cb(251) > attacheck clock:com.samsung.chronograph16
05-25 17:07:55.841+0900 W/AUL_AMD ( 2490): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(org.example.clover), key(end), value(ok)
05-25 17:07:55.851+0900 E/STARTER ( 2650): pkg-monitor.c: _pkg_monitor_get_metadata(136) > [_pkg_monitor_get_metadata:136] Failed to get metadata value[-2]
05-25 17:07:55.861+0900 E/WMS     ( 2450): wms_event_handler.c: _wms_event_handler_cb_log_package(4744) > package [_________] callback : [INSTALL, COMPLETED]
05-25 17:07:55.861+0900 E/WMS     ( 2450): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7080) > package install complete
05-25 17:07:55.861+0900 E/WMS     ( 2450): wms_event_handler.c: _wms_event_handler_package_install_event(5034) > 
05-25 17:07:55.861+0900 E/WMS     ( 2450): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(2040) > Found in install_req_list?[0], index[-1]
05-25 17:07:55.861+0900 E/WMS     ( 2450): wms_event_handler.c: _wms_event_handler_package_install_event(5060) > triggered from Gear itself.
05-25 17:07:55.901+0900 E/PKGMGR_INFO(10246): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(1026) > callback is stopped.
05-25 17:07:55.911+0900 E/PKGMGR_OBSERVER(10246): pkg_observer.c: main(620) > OBSERVER end
05-25 17:07:55.931+0900 E/PKGMGR_SERVER(10244): pkgmgr-server.c: sighandler(486) > child NORMAL exit [10246]
05-25 17:07:55.931+0900 E/WMS     ( 2450): wms_db.c: wms_db_package_event_insert_record(190) > 
05-25 17:07:55.931+0900 E/PKGMGR_INFO( 2447): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(922) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
05-25 17:07:55.941+0900 E/WMS     ( 2450): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2886) > send_install_response completed : END
05-25 17:07:55.961+0900 W/APPS    ( 2724): AppsViewNecklace.cpp: onTouchEventCancel(4949) >  touch cancel
05-25 17:07:55.991+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:07:56.021+0900 W/MM_CAMCORDER(10257): mm_camcorder_internal.c: _mmcamcorder_constructor(203) >  start
05-25 17:07:56.021+0900 W/MM_CAMCORDER(10257): mm_camcorder_internal.c: _mmcamcorder_constructor(213) >  done
05-25 17:07:56.021+0900 I/efl-extension(10257): efl_extension.c: eext_mod_init(40) > Init
05-25 17:07:56.191+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:07:56.391+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:07:56.591+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:07:56.661+0900 E/PKGMGR_SERVER(10244): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=0, queue_status=1] 
05-25 17:07:56.791+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:07:56.901+0900 I/AUL     (10257): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:07:56.911+0900 I/AUL     (10257): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:07:56.911+0900 E/AUL     (10257): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:07:56.911+0900 E/AUL     (10257): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:07:56.921+0900 I/AUL     (10257): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:07:56.931+0900 I/AUL     (10257): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:07:56.931+0900 E/AUL     (10257): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:07:56.931+0900 E/AUL     (10257): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:07:56.941+0900 I/AUL     (10257): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:07:56.951+0900 I/AUL     (10257): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:07:56.961+0900 E/AUL     (10257): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:07:56.961+0900 E/AUL     (10257): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:07:56.971+0900 I/AUL     (10257): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:07:56.981+0900 I/AUL     (10257): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:07:56.981+0900 E/AUL     (10257): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:07:56.981+0900 E/AUL     (10257): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:07:56.991+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:07:56.991+0900 I/AUL     (10257): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:07:57.011+0900 I/AUL     (10257): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:07:57.011+0900 E/AUL     (10257): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:07:57.011+0900 E/AUL     (10257): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:07:57.021+0900 I/AUL     (10257): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:07:57.031+0900 I/AUL     (10257): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:07:57.031+0900 E/AUL     (10257): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:07:57.031+0900 E/AUL     (10257): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:07:57.051+0900 I/AUL     (10257): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:07:57.061+0900 I/AUL     (10257): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:07:57.061+0900 E/AUL     (10257): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:07:57.061+0900 E/AUL     (10257): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:07:57.081+0900 I/AUL     (10257): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:07:57.091+0900 I/AUL     (10257): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:07:57.091+0900 E/AUL     (10257): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:07:57.091+0900 E/AUL     (10257): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:07:57.111+0900 I/UXT     (10257): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
05-25 17:07:57.191+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:07:57.291+0900 E/MALI    (10257): mali_egl_winsys.c: window_surface_new(889) >  Create Window, it runs with MALI_X11_ASYNC_PAGEFLIP 1 
05-25 17:07:57.291+0900 W/CoreGL  (10257): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[3] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:07:57.291+0900 W/CoreGL  (10257): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[7] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:07:57.301+0900 W/CoreGL  (10257): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[11] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:07:57.301+0900 W/CoreGL  (10257): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[15] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:07:57.301+0900 W/CoreGL  (10257): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[19] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:07:57.301+0900 W/CoreGL  (10257): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[23] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:07:57.301+0900 W/CoreGL  (10257): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[27] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:07:57.311+0900 W/CoreGL  (10257): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[31] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:07:57.311+0900 W/CoreGL  (10257): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[35] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:07:57.311+0900 W/CoreGL  (10257): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[39] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:07:57.311+0900 W/CoreGL  (10257): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[43] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:07:57.311+0900 W/CoreGL  (10257): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[47] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:07:57.311+0900 W/CoreGL  (10257): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[51] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:07:57.311+0900 W/CoreGL  (10257): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[55] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:07:57.311+0900 W/CoreGL  (10257): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[59] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:07:57.311+0900 W/CoreGL  (10257): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[63] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:07:57.311+0900 W/CoreGL  (10257): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[3] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:07:57.311+0900 W/CoreGL  (10257): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[7] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:07:57.311+0900 W/CoreGL  (10257): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[11] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:07:57.311+0900 W/CoreGL  (10257): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[15] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:07:57.311+0900 W/CoreGL  (10257): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[19] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:07:57.311+0900 W/CoreGL  (10257): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[23] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:07:57.321+0900 W/CoreGL  (10257): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[27] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:07:57.321+0900 W/CoreGL  (10257): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[31] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:07:57.321+0900 W/CoreGL  (10257): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[35] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:07:57.321+0900 W/CoreGL  (10257): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[39] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:07:57.321+0900 W/CoreGL  (10257): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[43] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:07:57.321+0900 W/CoreGL  (10257): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[47] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:07:57.321+0900 W/CoreGL  (10257): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[51] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:07:57.321+0900 W/CoreGL  (10257): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[55] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:07:57.321+0900 W/CoreGL  (10257): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[59] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:07:57.321+0900 W/CoreGL  (10257): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[63] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:07:57.321+0900 W/CoreGL  (10257): coregl_fastpath.c: fastpath_init_context_states(1463) >  [40;31;1mNumber of uniform buffer binding is too big! (64-72)[0m
05-25 17:07:57.321+0900 W/CoreGL  (10257): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
05-25 17:07:57.321+0900 W/CoreGL  (10257): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
05-25 17:07:57.391+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:07:57.591+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:07:57.791+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:07:57.821+0900 E/rpm-installer(10245): rpm-appcore-intf.c: main(273) > ------------------------------------------------
05-25 17:07:57.821+0900 E/rpm-installer(10245): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
05-25 17:07:57.821+0900 E/rpm-installer(10245): rpm-appcore-intf.c: main(275) > ------------------------------------------------
05-25 17:07:57.861+0900 E/PKGMGR_SERVER(10244): pkgmgr-server.c: sighandler(486) > child NORMAL exit [10245]
05-25 17:07:57.921+0900 E/RESOURCED( 2613): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/10245/oom_score_adj failed
05-25 17:07:57.921+0900 E/RESOURCED( 2613): proc-main.c: resourced_proc_status_change(1504) > Empty pid or process not exists. 10245
05-25 17:07:57.991+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:07:58.191+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:07:58.391+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:07:58.591+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:07:58.601+0900 I/AUL     (10278): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
05-25 17:07:58.621+0900 I/AUL     (10278): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:07:58.621+0900 E/AUL     (10278): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:07:58.621+0900 E/AUL     (10278): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:07:58.661+0900 E/PKGMGR_SERVER(10244): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=1, queue_status=1] 
05-25 17:07:58.661+0900 E/PKGMGR_SERVER(10244): pkgmgr-server.c: main(2281) > package manager server terminated.
05-25 17:07:58.791+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:07:58.841+0900 W/AUL     (10343): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.clover)
05-25 17:07:58.841+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 0
05-25 17:07:58.861+0900 I/AUL_AMD ( 2490): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
05-25 17:07:58.871+0900 I/AUL_AMD ( 2490): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
05-25 17:07:58.871+0900 E/AUL_AMD ( 2490): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
05-25 17:07:58.871+0900 W/AUL_AMD ( 2490): amd_launch.c: _start_app(1782) > caller pid : 10343
05-25 17:07:58.891+0900 E/RESOURCED( 2613): block.c: block_prelaunch_state(138) > insert data org.example.clover, table num : 3
05-25 17:07:58.891+0900 W/AUL_AMD ( 2490): amd_launch.c: _start_app(2218) > pad pid(-5)
05-25 17:07:58.891+0900 W/AUL_PAD ( 3264): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
05-25 17:07:58.911+0900 W/AUL_PAD (10255): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
05-25 17:07:58.911+0900 W/AUL_PAD (10255): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
05-25 17:07:58.911+0900 W/AUL_PAD (10255): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
05-25 17:07:58.911+0900 W/AUL_PAD (10255): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.clover)
05-25 17:07:58.911+0900 W/AUL_PAD ( 3264): launchpad.c: __send_result_to_caller(272) > Check app launching
05-25 17:07:58.991+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:07:59.001+0900 I/efl-extension(10255): efl_extension.c: eext_mod_init(40) > Init
05-25 17:07:59.001+0900 W/AUL_PAD (10255): launchpad_loader.c: main(690) > [candidate] dlsym
05-25 17:07:59.001+0900 W/AUL_PAD (10255): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.clover)
05-25 17:07:59.001+0900 I/CAPI_APPFW_APPLICATION(10255): app_main.c: ui_app_main(704) > app_efl_main
05-25 17:07:59.011+0900 I/CAPI_APPFW_APPLICATION(10255): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-25 17:07:59.011+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.clover) pid(10255) type(uiapp) bg(0)
05-25 17:07:59.011+0900 W/AUL     (10343): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10255)
05-25 17:07:59.021+0900 W/AUL_AMD ( 2490): amd_status.c: __socket_monitor_cb(1277) > (10255) was created
05-25 17:07:59.061+0900 W/STARTER ( 2650): pkg-monitor.c: _app_mgr_status_cb(394) > [_app_mgr_status_cb:394] Launch request [10255]
05-25 17:07:59.171+0900 E/EFL     (10255): ecore_evas<10255> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-25 17:07:59.191+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:07:59.211+0900 W/W_HOME  ( 2724): event_manager.c: _ecore_x_message_cb(428) > state: 0 -> 1
05-25 17:07:59.211+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:07:59.211+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:07:59.221+0900 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
05-25 17:07:59.221+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
05-25 17:07:59.221+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:07:59.221+0900 W/W_HOME  ( 2724): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 0
05-25 17:07:59.281+0900 E/EFL     (10255): elementary<10255> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
05-25 17:07:59.291+0900 E/EFL     (10255): elementary<10255> elc_naviframe.c:2950 elm_naviframe_item_push() item(0xf7cde2e8) will be pushed
05-25 17:07:59.341+0900 E/TIZEN_N_RECORDER(10255): recorder.c: __convert_recorder_error_code(193) > [audio-channel] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:07:59.341+0900 E/TIZEN_N_RECORDER(10255): recorder.c: __convert_recorder_error_code(193) > [audio-device] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:07:59.341+0900 I/APP_CORE(10255): appcore-efl.c: __do_app(453) > [APP 10255] Event: RESET State: CREATED
05-25 17:07:59.341+0900 I/CAPI_APPFW_APPLICATION(10255): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-25 17:07:59.361+0900 I/APP_CORE(10255): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
05-25 17:07:59.361+0900 I/APP_CORE(10255): appcore-efl.c: __do_app(524) > [APP 10255] Initial Launching, call the resume_cb
05-25 17:07:59.361+0900 I/CAPI_APPFW_APPLICATION(10255): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-25 17:07:59.371+0900 W/APP_CORE(10255): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3600002
05-25 17:07:59.391+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:07:59.441+0900 W/W_HOME  ( 2724): event_manager.c: _window_visibility_cb(473) > Window [0x1E00003] is now visible(1)
05-25 17:07:59.441+0900 W/W_HOME  ( 2724): event_manager.c: _window_visibility_cb(483) > state: 1 -> 0
05-25 17:07:59.441+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:07:59.441+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(327) > appcore paused manually
05-25 17:07:59.441+0900 W/W_HOME  ( 2724): main.c: home_appcore_pause(515) > Home Appcore Paused
05-25 17:07:59.441+0900 W/W_HOME  ( 2724): event_manager.c: _app_pause_cb(397) > state: 1 -> 2
05-25 17:07:59.441+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:07:59.441+0900 I/APP_CORE(10255): appcore-efl.c: __do_app(453) > [APP 10255] Event: RESUME State: RUNNING
05-25 17:07:59.441+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:07:59.441+0900 W/W_HOME  ( 2724): main.c: home_pause(547) > clock/widget paused
05-25 17:07:59.441+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:07:59.441+0900 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
05-25 17:07:59.441+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
05-25 17:07:59.441+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-25 17:07:59.441+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-25 17:07:59.441+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-25 17:07:59.441+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-25 17:07:59.441+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-25 17:07:59.441+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-25 17:07:59.441+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-25 17:07:59.441+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:07:59.441+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-25 17:07:59.441+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-25 17:07:59.441+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-25 17:07:59.441+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-25 17:07:59.441+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
05-25 17:07:59.441+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-25 17:07:59.441+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-25 17:07:59.441+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-25 17:07:59.441+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-25 17:07:59.441+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:07:59.441+0900 E/CAPI_APPFW_APP_CONTROL( 2895): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-25 17:07:59.441+0900 W/MUSIC_CONTROL_SERVICE( 2895): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:2895]   [com.samsung.w-home]register msg port [false][0m
05-25 17:07:59.441+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:07:59.441+0900 W/W_HOME  ( 2724): main.c: _window_visibility_cb(964) > Window [0x1E00003] is now visible(1)
05-25 17:07:59.441+0900 I/APP_CORE( 2724): appcore-efl.c: __do_app(453) > [APP 2724] Event: PAUSE State: RUNNING
05-25 17:07:59.441+0900 I/CAPI_APPFW_APPLICATION( 2724): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-25 17:07:59.441+0900 W/W_HOME  ( 2724): main.c: _appcore_pause_cb(488) > appcore pause
05-25 17:07:59.441+0900 E/W_HOME  ( 2724): main.c: _pause_cb(466) > paused already
05-25 17:07:59.461+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2724) status(bg) type(uiapp)
05-25 17:07:59.461+0900 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2724] goes to (4)
05-25 17:07:59.461+0900 E/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2724)'s state(4)
05-25 17:07:59.461+0900 I/wnotib  ( 2724): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
05-25 17:07:59.461+0900 E/wnotib  ( 2724): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-25 17:07:59.461+0900 W/wnotib  ( 2724): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [3], notiboard card appending count [8].
05-25 17:07:59.461+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_unset_buffer(1602) > [4124.804107] layer(0x874f48) now usable
05-25 17:07:59.461+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [4124.804128] layer[0x8749e8]zpos[0]
05-25 17:07:59.461+0900 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[10255] goes to (3)
05-25 17:07:59.461+0900 W/AUL_AMD ( 2490): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-25 17:07:59.461+0900 W/AUL_AMD ( 2490): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
05-25 17:07:59.461+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.clover) pid(10255) status(fg) type(uiapp)
05-25 17:07:59.471+0900 W/WATCH_CORE( 2779): appcore-watch.c: __widget_pause(1113) > widget_pause
05-25 17:07:59.471+0900 W/AUL     ( 2779): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.chronograph16) pid(2779) status(bg) type(watchapp)
05-25 17:07:59.471+0900 D/chronograph( 2779): ChronographApp.cpp: _appPause(150) > [0;34m>>>HIT<<<[0;m
05-25 17:07:59.471+0900 W/chronograph( 2779): ChronographViewController.cpp: onPause(183) > [0;35mState is Pause[isPaused=1], StopwatchState=0[0;m
05-25 17:07:59.471+0900 W/chronograph( 2779): ChronographSweepSecond.cpp: resetSweepSecond(103) > [0;35mresetSweepSecond >>>>[0;m
05-25 17:07:59.471+0900 D/chronograph( 2779): ChronographSweepSecond.cpp: resetSweepSecond(107) > Stop and Clear sweepAnimation !!
05-25 17:07:59.471+0900 D/chronograph-common( 2779): ChronographSensor.cpp: disableAcceleormeter(52) > [0;32mBEGIN >>>>[0;m
05-25 17:07:59.471+0900 D/chronograph-common( 2779): ChronographSensor.cpp: _stopAccelerometer(129) > [0;32mBEGIN >>>>[0;m
05-25 17:07:59.831+0900 E/AUL     ( 2490): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
05-25 17:07:59.941+0900 I/APP_CORE( 2724): appcore-efl.c: __do_app(453) > [APP 2724] Event: MEM_FLUSH State: PAUSED
05-25 17:08:00.101+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 14
05-25 17:08:00.111+0900 W/AUL_AMD ( 2490): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10255
05-25 17:08:00.111+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 12
05-25 17:08:00.131+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 14
05-25 17:08:00.141+0900 W/AUL_AMD ( 2490): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10255
05-25 17:08:00.141+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 12
05-25 17:08:00.301+0900 I/AUL_PAD (10348): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
05-25 17:08:03.601+0900 E/WMS     ( 2450): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23510) > _wms_event_handler_cb_nomove_detector is called
05-25 17:08:04.451+0900 I/APP_CORE( 2724): appcore-efl.c: __do_app(453) > [APP 2724] Event: MEM_FLUSH State: PAUSED
05-25 17:08:09.131+0900 E/EFL     (10255): ecore_x<10255> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=4134469 button=1
05-25 17:08:09.231+0900 E/EFL     (10255): ecore_x<10255> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=4134572 button=1
05-25 17:08:09.311+0900 I/USR_TAG (10255): record_start
05-25 17:08:09.311+0900 E/TIZEN_N_RECORDER(10255): recorder.c: __convert_recorder_error_code(193) > [recorder_attr_set_time_limit] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:08:09.311+0900 E/TIZEN_N_RECORDER(10255): recorder.c: __convert_recorder_error_code(193) > [recorder_set_filename] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:08:09.311+0900 E/TIZEN_N_RECORDER(10255): recorder.c: __convert_recorder_error_code(193) > [file-format] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:08:09.311+0900 E/TIZEN_N_RECORDER(10255): recorder.c: __convert_recorder_error_code(193) > [audio-encoder] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:08:09.751+0900 E/TIZEN_N_RECORDER(10255): recorder.c: __convert_recorder_error_code(193) > [recorder_start] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:08:09.751+0900 E/EFL     (10255): <10255> elm_main.c:1300 elm_object_disabled_set() safety check failed: obj == NULL
05-25 17:08:09.751+0900 E/EFL     (10255): <10255> elm_main.c:1300 elm_object_disabled_set() safety check failed: obj == NULL
05-25 17:08:09.771+0900 E/EFL     (10255): elementary<10255> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
05-25 17:08:09.781+0900 E/EFL     (10255): elementary<10255> elc_naviframe.c:2950 elm_naviframe_item_push() item(0xf247cbf8) will be pushed
05-25 17:08:09.781+0900 E/EFL     (10255): elementary<10255> elc_naviframe.c:2796 _push_transition_cb() item(0xf247cbf8) will transition
05-25 17:08:10.221+0900 E/EFL     (10255): elementary<10255> elc_naviframe.c:1193 _on_item_push_finished() item(0xf7cde2e8) transition finished
05-25 17:08:10.221+0900 E/EFL     (10255): elementary<10255> elc_naviframe.c:1218 _on_item_show_finished() item(0xf247cbf8) transition finished
05-25 17:08:10.231+0900 E/EFL     ( 2318): ecore_x<2318> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x3600002 time=4135125
05-25 17:08:10.231+0900 E/EFL     (10255): ecore_x<10255> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=4135125
05-25 17:08:10.231+0900 E/EFL     ( 2318): ecore_x<2318> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=4135125
05-25 17:08:10.801+0900 E/WMS     ( 2450): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23510) > _wms_event_handler_cb_nomove_detector is called
05-25 17:08:15.661+0900 I/USR_TAG (10255): loud sound is detected!
05-25 17:08:15.981+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 10255 pgid = 10255
05-25 17:08:15.981+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
05-25 17:08:16.001+0900 W/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
05-25 17:08:16.001+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
05-25 17:08:16.001+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:08:16.011+0900 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2724] goes to (3)
05-25 17:08:16.011+0900 E/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2724)'s state(3)
05-25 17:08:16.011+0900 W/AUL_AMD ( 2490): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-25 17:08:16.011+0900 W/AUL_AMD ( 2490): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
05-25 17:08:16.011+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2724) status(fg) type(uiapp)
05-25 17:08:16.061+0900 W/PROCESSMGR( 2318): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
05-25 17:08:16.121+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
05-25 17:08:16.121+0900 I/AUL_AMD ( 2490): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10255
05-25 17:08:16.121+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(10255)
05-25 17:08:16.131+0900 W/W_HOME  ( 2724): event_manager.c: _ecore_x_message_cb(428) > state: 1 -> 0
05-25 17:08:16.131+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:08:16.131+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:08:16.131+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:08:16.131+0900 W/W_HOME  ( 2724): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
05-25 17:08:16.141+0900 W/W_HOME  ( 2724): event_manager.c: _window_visibility_cb(473) > Window [0x1E00003] is now visible(0)
05-25 17:08:16.141+0900 W/W_HOME  ( 2724): event_manager.c: _window_visibility_cb(483) > state: 0 -> 1
05-25 17:08:16.141+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:08:16.141+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:08:16.151+0900 W/W_HOME  ( 2724): main.c: _window_visibility_cb(964) > Window [0x1E00003] is now visible(0)
05-25 17:08:16.151+0900 W/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
05-25 17:08:16.151+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
05-25 17:08:16.151+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:08:16.151+0900 I/APP_CORE( 2724): appcore-efl.c: __do_app(453) > [APP 2724] Event: RESUME State: PAUSED
05-25 17:08:16.151+0900 I/CAPI_APPFW_APPLICATION( 2724): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-25 17:08:16.151+0900 W/W_HOME  ( 2724): main.c: _appcore_resume_cb(479) > appcore resume
05-25 17:08:16.151+0900 W/W_HOME  ( 2724): event_manager.c: _app_resume_cb(380) > state: 2 -> 1
05-25 17:08:16.151+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:08:16.151+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:08:16.151+0900 W/W_HOME  ( 2724): main.c: home_resume(527) > journal_multimedia_screen_loaded_home called
05-25 17:08:16.151+0900 W/W_HOME  ( 2724): main.c: home_resume(531) > clock/widget resumed
05-25 17:08:16.151+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:08:16.161+0900 I/wnotib  ( 2724): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 0
05-25 17:08:16.161+0900 E/wnotib  ( 2724): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-25 17:08:16.161+0900 W/wnotib  ( 2724): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
05-25 17:08:16.161+0900 W/WATCH_CORE( 2779): appcore-watch.c: __widget_resume(1124) > widget_resume
05-25 17:08:16.161+0900 W/AUL     ( 2779): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.chronograph16) pid(2779) status(fg) type(watchapp)
05-25 17:08:16.171+0900 D/chronograph( 2779): ChronographApp.cpp: _appResume(161) > [0;34m>>>HIT<<<[0;m
05-25 17:08:16.171+0900 D/chronograph( 2779): ChronographViewController.cpp: onResume(221) > State is Resume[isPaused=0], StopwatchState=0
05-25 17:08:16.171+0900 W/chronograph( 2779): ChronographSweepSecond.cpp: setSweepSecond(55) > [0;35msetSweepSecond >>>>[0;m
05-25 17:08:16.171+0900 D/chronograph( 2779): ChronographSweepSecond.cpp: setSweepSecond(67) > Current sec = 16, msec = 179
05-25 17:08:16.171+0900 D/chronograph( 2779): ChronographSweepSecond.cpp: setSweepSecond(71) > Create sweepSecondAnimation !!
05-25 17:08:16.171+0900 D/chronograph-common( 2779): ChronographSensor.cpp: enableAccelerometer(44) > [0;32mBEGIN >>>>[0;m
05-25 17:08:16.171+0900 D/chronograph-common( 2779): ChronographSensor.cpp: _startAccelerometer(75) > [0;32mBEGIN >>>>[0;m
05-25 17:08:16.201+0900 W/CRASH_MANAGER(10360): worker.c: worker_job(1199) > 1110255636c6f149569969

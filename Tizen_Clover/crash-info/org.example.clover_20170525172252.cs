S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.1
Build-Number: R760XXU1APL2
Build-Date: 2016.12.20 22:57:01

Crash Information
Process Name: clover
PID: 12794
Date: 2017-05-25 17:22:52+0900
Executable File Path: /opt/usr/apps/org.example.clover/bin/clover
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 12794, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0xf5ee0264, r3   = 0x00000001
r4   = 0xf72a89b8, r5   = 0xf72a89b8
r6   = 0xf72a816c, r7   = 0xffe8d630
r8   = 0xf72a89b8, r9   = 0xf7a7cb80
r10  = 0xf72b6b10, fp   = 0x00000000
ip   = 0xf5ee02a4, sp   = 0xffe8d5e8
lr   = 0xf706c5d0, pc   = 0xf5ecc562
cpsr = 0x60000030

Memory Information
MemTotal:   714608 KB
MemFree:     19992 KB
Buffers:     31408 KB
Cached:     166756 KB
VmPeak:     189976 KB
VmSize:     189972 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       37104 KB
VmRSS:       37100 KB
VmData:     111932 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       29384 KB
VmPTE:         188 KB
VmSwap:          0 KB

Threads Information
Threads: 11
PID = 12794 TID = 12794
12794 12874 12875 12904 12905 12906 12907 12908 12909 12910 12911 

Maps Information
ed1fe000 ed9fd000 rw-p [stack:12911]
ed9fe000 ee5fe000 rw-p [stack:12910]
ee5ff000 eedfe000 rw-p [stack:12909]
eedff000 ef5fe000 rw-p [stack:12908]
efe01000 f0600000 rw-p [stack:12907]
f0601000 f0e00000 rw-p [stack:12906]
f0fa3000 f0fa6000 r-xp /usr/lib/gstreamer-0.10/libgstwavenc.so
f0fae000 f0fc8000 r-xp /usr/lib/gstreamer-0.10/libgstpulse.so
f0fd1000 f1009000 r-xp /usr/lib/libsamrnb.so
f102c000 f1037000 r-xp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
f1040000 f1050000 r-xp /usr/lib/gstreamer-0.10/libgstalsa.so
f1058000 f105e000 r-xp /usr/lib/libscmn.so
f1066000 f109e000 r-xp /usr/lib/libsaac.so
f10a8000 f10ad000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencamrnb.so
f10b5000 f10c5000 r-xp /usr/lib/lib_SamsungRec_TizenV04015.so
f10e6000 f10ee000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
f10fd000 f1102000 r-xp /usr/lib/gstreamer-0.10/libgstsecrecord.so
f1114000 f112c000 r-xp /usr/lib/libgstcontroller-0.10.so.0.30.0
f113c000 f1142000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencaac.so
f114a000 f1162000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
f116b000 f1194000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
f11a6000 f11ab000 r-xp /usr/lib/gstreamer-0.10/libgstvolume.so
f11b3000 f1311000 r-xp /usr/lib/gstreamer-0.10/libgstffmpeg.so
f13f9000 f1405000 r-xp /usr/lib/gstreamer-0.10/libgstencodebin.so
f140d000 f142d000 r-xp /usr/lib/gstreamer-0.10/libgstomx.so
f142e000 f1462000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
f146b000 f1476000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
f147e000 f1480000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
f1488000 f1489000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
f1491000 f1499000 r-xp /usr/lib/libfeedback.so.0.1.4
f149e000 f14a1000 r-xp /usr/lib/gstreamer-0.10/libgstavsysaudiosrc.so
f14a9000 f14aa000 r-xp /usr/lib/gstreamer-0.10/libgstapp.so
f1532000 f1d31000 rw-p [stack:12875]
f1d32000 f2531000 rw-p [stack:12874]
f25d9000 f2dd8000 rw-p [stack:12904]
f3001000 f3002000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
f300a000 f300b000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
f3026000 f3825000 rw-p [stack:12905]
f3825000 f3827000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
f382f000 f3846000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f3853000 f3858000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f3860000 f386b000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f3ba5000 f3c97000 r-xp /usr/lib/libCOREGL.so.4.0
f3cb0000 f3cb5000 r-xp /usr/lib/libsystem.so.0.0.0
f3cbf000 f3cc0000 r-xp /usr/lib/libresponse.so.0.2.96
f3cc8000 f3ccd000 r-xp /usr/lib/libproc-stat.so.0.2.96
f3cd6000 f3cd8000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f3ce0000 f3ce7000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f3cf0000 f3d12000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f3d1b000 f3d1f000 r-xp /usr/lib/libogg.so.0.7.1
f3d27000 f3d49000 r-xp /usr/lib/libvorbis.so.0.4.3
f3d51000 f3d54000 r-xp /usr/lib/libtinycompress.so.0.0.0
f3d5c000 f3d6b000 r-xp /usr/lib/libmdm-common.so.1.1.22
f3d74000 f3d7c000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f3d84000 f3d8a000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f3d93000 f3d9a000 r-xp /usr/lib/libminizip.so.1.0.0
f3da2000 f3da4000 r-xp /usr/lib/libttrace.so.1.1
f3dac000 f3df3000 r-xp /usr/lib/libsndfile.so.1.0.26
f3dff000 f3e48000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f3e51000 f3e56000 r-xp /usr/lib/libjson.so.0.0.1
f56ef000 f57f5000 r-xp /usr/lib/libicuuc.so.57.1
f580b000 f5993000 r-xp /usr/lib/libicui18n.so.57.1
f59a3000 f59b0000 r-xp /usr/lib/libail.so.0.1.0
f59b9000 f59bc000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f59c4000 f59c7000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f59cf000 f5a30000 r-xp /usr/lib/libasound.so.2.0.0
f5a3a000 f5a50000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f5a58000 f5a5c000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f5a64000 f5aa5000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
f5aae000 f5ab0000 r-xp /usr/lib/libdri2.so.0.0.0
f5ab8000 f5ac0000 r-xp /usr/lib/libdrm.so.2.4.0
f5ac8000 f5ace000 r-xp /usr/lib/libxcb-render.so.0.0.0
f5ad6000 f5ad7000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f5ae0000 f5ae4000 r-xp /usr/lib/libEGL.so.1.4
f5af4000 f5b05000 r-xp /usr/lib/libGLESv2.so.2.0
f5b15000 f5b5d000 r-xp /usr/lib/libmdm.so.1.2.62
f5b5e000 f5b65000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f5b6d000 f5b78000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f5b85000 f5b9e000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f5ba6000 f5bab000 r-xp /usr/lib/libstorage.so.0.1
f5bb3000 f5bb8000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f5bc0000 f5bf8000 r-xp /usr/lib/libpulse.so.0.16.2
f5bf9000 f5bfd000 r-xp /usr/lib/libmmfsession.so.0.0.0
f5c06000 f5c1d000 r-xp /usr/lib/libmmfsound.so.0.1.0
f5c2f000 f5c50000 r-xp /usr/lib/libexif.so.12.3.3
f5c63000 f5c6c000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
f5c74000 f5c81000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
f5c8a000 f5c95000 r-xp /usr/lib/libtbm.so.1.0.0
f5c9d000 f5ca2000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f5caa000 f5d62000 r-xp /usr/lib/libcairo.so.2.11200.14
f5d6d000 f5e08000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
f5e14000 f5e64000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
f5e6a000 f5e7c000 r-xp /usr/lib/libcapi-media-camera.so.0.1.35
f5e84000 f5ea5000 r-xp /usr/lib/libefl-extension.so.0.1.0
f5ead000 f5eb2000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5eba000 f5ec2000 r-xp /usr/lib/libcapi-media-recorder.so.0.1.28
f5eca000 f5ed1000 r-xp /opt/usr/apps/org.example.clover/bin/clover
f6073000 f607d000 r-xp /lib/libnss_files-2.13.so
f6086000 f6155000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f616b000 f618f000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f6198000 f619e000 r-xp /usr/lib/libappsvc.so.0.1.0
f61a6000 f61a8000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f61b1000 f61b5000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f61c1000 f61cc000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f61d4000 f61d6000 r-xp /usr/lib/libiniparser.so.0
f61df000 f61e4000 r-xp /usr/lib/libappcore-common.so.1.1
f61ec000 f61ee000 r-xp /usr/lib/libcamsrcjpegenc.so.0.0.0
f61f6000 f61fa000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f6207000 f6209000 r-xp /usr/lib/libXau.so.6.0.0
f6211000 f6218000 r-xp /lib/libcrypt-2.13.so
f6248000 f624a000 r-xp /usr/lib/libiri.so
f6253000 f63fc000 r-xp /usr/lib/libcrypto.so.1.0.0
f641c000 f6463000 r-xp /usr/lib/libssl.so.1.0.0
f646f000 f649d000 r-xp /usr/lib/libidn.so.11.5.44
f64a5000 f64ae000 r-xp /usr/lib/libcares.so.2.1.0
f64b8000 f64cb000 r-xp /usr/lib/libxcb.so.1.1.0
f64d4000 f64d6000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f64de000 f64e0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f64e9000 f65b5000 r-xp /usr/lib/libxml2.so.2.7.8
f65c2000 f65c4000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f65cd000 f65d2000 r-xp /usr/lib/libffi.so.5.0.10
f65da000 f65db000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f65e3000 f65e6000 r-xp /lib/libattr.so.1.1.0
f65ee000 f6682000 r-xp /usr/lib/libstdc++.so.6.0.16
f6695000 f66b2000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f66bc000 f66d4000 r-xp /usr/lib/libpng12.so.0.50.0
f66dc000 f66f2000 r-xp /lib/libexpat.so.1.6.0
f66fc000 f6740000 r-xp /usr/lib/libcurl.so.4.3.0
f6749000 f6753000 r-xp /usr/lib/libXext.so.6.4.0
f675c000 f6760000 r-xp /usr/lib/libXtst.so.6.1.0
f6768000 f676e000 r-xp /usr/lib/libXrender.so.1.3.0
f6776000 f677c000 r-xp /usr/lib/libXrandr.so.2.2.0
f6784000 f6785000 r-xp /usr/lib/libXinerama.so.1.0.0
f678e000 f6797000 r-xp /usr/lib/libXi.so.6.1.0
f679f000 f67a2000 r-xp /usr/lib/libXfixes.so.3.1.0
f67aa000 f67ac000 r-xp /usr/lib/libXgesture.so.7.0.0
f67b4000 f67b6000 r-xp /usr/lib/libXcomposite.so.1.0.0
f67be000 f67c0000 r-xp /usr/lib/libXdamage.so.1.1.0
f67c8000 f67cf000 r-xp /usr/lib/libXcursor.so.1.0.2
f67d7000 f67da000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f67e2000 f67e6000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f67ef000 f67f4000 r-xp /usr/lib/libecore_fb.so.1.7.99
f67fd000 f68de000 r-xp /usr/lib/libX11.so.6.3.0
f68e9000 f690c000 r-xp /usr/lib/libjpeg.so.8.0.2
f6924000 f693a000 r-xp /lib/libz.so.1.2.5
f6942000 f6944000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f694c000 f69c1000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69cb000 f69e5000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f69ed000 f6a21000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6a2a000 f6afd000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6b08000 f6b18000 r-xp /lib/libresolv-2.13.so
f6b1c000 f6b34000 r-xp /usr/lib/liblzma.so.5.0.3
f6b3c000 f6b3f000 r-xp /lib/libcap.so.2.21
f6b47000 f6b76000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b7e000 f6b7f000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f6b87000 f6b8d000 r-xp /usr/lib/libecore_imf.so.1.7.99
f6b95000 f6bac000 r-xp /usr/lib/liblua-5.1.so
f6bb5000 f6bbc000 r-xp /usr/lib/libembryo.so.1.7.99
f6bc4000 f6bca000 r-xp /lib/librt-2.13.so
f6bd3000 f6c29000 r-xp /usr/lib/libpixman-1.so.0.28.2
f6c36000 f6c8c000 r-xp /usr/lib/libfreetype.so.6.11.3
f6c98000 f6cc0000 r-xp /usr/lib/libfontconfig.so.1.8.0
f6cc1000 f6d06000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6d0f000 f6d22000 r-xp /usr/lib/libfribidi.so.0.3.1
f6d2a000 f6d44000 r-xp /usr/lib/libecore_con.so.1.7.99
f6d4d000 f6d56000 r-xp /usr/lib/libedbus.so.1.7.99
f6d5e000 f6dae000 r-xp /usr/lib/libecore_x.so.1.7.99
f6db0000 f6db9000 r-xp /usr/lib/libvconf.so.0.2.45
f6dc1000 f6dd2000 r-xp /usr/lib/libecore_input.so.1.7.99
f6dda000 f6ddf000 r-xp /usr/lib/libecore_file.so.1.7.99
f6de7000 f6e09000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6e12000 f6e53000 r-xp /usr/lib/libeina.so.1.7.99
f6e5c000 f6e75000 r-xp /usr/lib/libeet.so.1.7.99
f6e86000 f6eef000 r-xp /lib/libm-2.13.so
f6ef8000 f6efe000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f07000 f6f08000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f10000 f6f33000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f3b000 f6f40000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f48000 f6f72000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f7b000 f6f92000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f9a000 f6fa5000 r-xp /lib/libunwind.so.8.0.1
f6fd2000 f6ff0000 r-xp /usr/lib/libsystemd.so.0.4.0
f6ffa000 f711e000 r-xp /lib/libc-2.13.so
f712c000 f7134000 r-xp /lib/libgcc_s-4.6.so.1
f7135000 f7139000 r-xp /usr/lib/libsmack.so.1.0.0
f7142000 f7148000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f7150000 f7220000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7221000 f727f000 r-xp /usr/lib/libedje.so.1.7.99
f7289000 f72a0000 r-xp /usr/lib/libecore.so.1.7.99
f72b7000 f7385000 r-xp /usr/lib/libevas.so.1.7.99
f73aa000 f74e6000 r-xp /usr/lib/libelementary.so.1.7.99
f74fd000 f7511000 r-xp /lib/libpthread-2.13.so
f751c000 f751e000 r-xp /usr/lib/libdlog.so.0.0.0
f7526000 f7529000 r-xp /usr/lib/libbundle.so.0.1.22
f7531000 f7533000 r-xp /lib/libdl-2.13.so
f753c000 f7549000 r-xp /usr/lib/libaul.so.0.1.0
f755a000 f7560000 r-xp /usr/lib/libappcore-efl.so.1.1
f7569000 f756d000 r-xp /usr/lib/libsys-assert.so
f7576000 f7593000 r-xp /lib/ld-2.13.so
f759c000 f75a1000 r-xp /usr/bin/launchpad-loader
f7a44000 f7bd4000 rw-p [heap]
ffe6e000 ffe8f000 rw-p [stack]
End of Maps Information

Callstack Information (PID:12794)
Call Stack Count: 12
 0: ecore_timer_cb + 0xc9 (0xf5ecc562) [/opt/usr/apps/org.example.clover/bin/clover] + 0x2562
 1: (0xf72981f9) [/usr/lib/libecore.so.1] + 0xf1f9
 2: (0xf72982ef) [/usr/lib/libecore.so.1] + 0xf2ef
 3: (0xf72952f3) [/usr/lib/libecore.so.1] + 0xc2f3
 4: ecore_main_loop_begin + 0x30 (0xf7295879) [/usr/lib/libecore.so.1] + 0xc879
 5: appcore_efl_main + 0x332 (0xf755db47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
 6: ui_app_main + 0xb0 (0xf61f8421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 7: uib_app_run + 0xea (0xf5eccf0f) [/opt/usr/apps/org.example.clover/bin/clover] + 0x2f0f
 8: main + 0x34 (0xf5ecc489) [/opt/usr/apps/org.example.clover/bin/clover] + 0x2489
 9: (0xf759da53) [/opt/usr/apps/org.example.clover/bin/clover] + 0x1a53
10: __libc_start_main + 0x114 (0xf701185c) [/lib/libc.so.6] + 0x1785c
11: (0xf759de0c) [/opt/usr/apps/org.example.clover/bin/clover] + 0x1e0c
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
  GL-state 'gl_vertex_attrib_value_integer'[35] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:22:42.731+0900 W/CoreGL  (12796): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[39] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:22:42.731+0900 W/CoreGL  (12796): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[43] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:22:42.731+0900 W/CoreGL  (12796): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[47] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:22:42.731+0900 W/CoreGL  (12796): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[51] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:22:42.731+0900 W/CoreGL  (12796): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[55] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:22:42.731+0900 W/CoreGL  (12796): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[59] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:22:42.731+0900 W/CoreGL  (12796): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[63] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:22:42.731+0900 W/CoreGL  (12796): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[3] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:22:42.731+0900 W/CoreGL  (12796): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[7] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:22:42.731+0900 W/CoreGL  (12796): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[11] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:22:42.731+0900 W/CoreGL  (12796): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[15] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:22:42.731+0900 W/CoreGL  (12796): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[19] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:22:42.731+0900 W/CoreGL  (12796): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[23] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:22:42.731+0900 W/CoreGL  (12796): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[27] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:22:42.731+0900 W/CoreGL  (12796): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[31] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:22:42.731+0900 W/CoreGL  (12796): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[35] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:22:42.731+0900 W/CoreGL  (12796): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[39] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:22:42.731+0900 W/CoreGL  (12796): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[43] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:22:42.731+0900 W/CoreGL  (12796): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[47] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:22:42.731+0900 W/CoreGL  (12796): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[51] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:22:42.731+0900 W/CoreGL  (12796): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[55] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:22:42.731+0900 W/CoreGL  (12796): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[59] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:22:42.731+0900 W/CoreGL  (12796): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[63] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:22:42.731+0900 W/CoreGL  (12796): coregl_fastpath.c: fastpath_init_context_states(1463) >  [40;31;1mNumber of uniform buffer binding is too big! (64-72)[0m
05-25 17:22:42.731+0900 W/CoreGL  (12796): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
05-25 17:22:42.731+0900 W/CoreGL  (12796): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
05-25 17:22:43.551+0900 E/rpm-installer(12784): rpm-appcore-intf.c: main(273) > ------------------------------------------------
05-25 17:22:43.551+0900 E/rpm-installer(12784): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
05-25 17:22:43.551+0900 E/rpm-installer(12784): rpm-appcore-intf.c: main(275) > ------------------------------------------------
05-25 17:22:43.561+0900 E/PKGMGR_SERVER(12730): pkgmgr-server.c: sighandler(486) > child NORMAL exit [12784]
05-25 17:22:43.601+0900 E/RESOURCED( 2613): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/12784/oom_score_adj failed
05-25 17:22:43.601+0900 E/RESOURCED( 2613): proc-main.c: resourced_proc_status_change(1504) > Empty pid or process not exists. 12784
05-25 17:22:43.661+0900 E/PKGMGR_SERVER(12730): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=1, queue_status=1] 
05-25 17:22:43.661+0900 E/PKGMGR_SERVER(12730): pkgmgr-server.c: main(2281) > package manager server terminated.
05-25 17:22:43.801+0900 I/AUL     (12806): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
05-25 17:22:43.811+0900 I/AUL     (12806): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:22:43.811+0900 E/AUL     (12806): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:22:43.811+0900 E/AUL     (12806): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:22:45.191+0900 W/AUL     (12871): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.clover)
05-25 17:22:45.191+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 0
05-25 17:22:45.211+0900 I/AUL_AMD ( 2490): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
05-25 17:22:45.231+0900 I/AUL_AMD ( 2490): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
05-25 17:22:45.231+0900 E/AUL_AMD ( 2490): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
05-25 17:22:45.231+0900 W/AUL_AMD ( 2490): amd_launch.c: _start_app(1782) > caller pid : 12871
05-25 17:22:45.251+0900 E/RESOURCED( 2613): block.c: block_prelaunch_state(138) > insert data org.example.clover, table num : 3
05-25 17:22:45.251+0900 W/AUL_AMD ( 2490): amd_launch.c: _start_app(2218) > pad pid(-5)
05-25 17:22:45.251+0900 W/AUL_PAD ( 3264): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
05-25 17:22:45.261+0900 W/AUL_PAD ( 3264): launchpad.c: __send_result_to_caller(272) > Check app launching
05-25 17:22:45.261+0900 W/AUL_PAD (12794): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
05-25 17:22:45.261+0900 W/AUL_PAD (12794): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
05-25 17:22:45.261+0900 W/AUL_PAD (12794): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
05-25 17:22:45.261+0900 W/AUL_PAD (12794): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.clover)
05-25 17:22:45.321+0900 I/efl-extension(12794): efl_extension.c: eext_mod_init(40) > Init
05-25 17:22:45.321+0900 W/AUL_PAD (12794): launchpad_loader.c: main(690) > [candidate] dlsym
05-25 17:22:45.321+0900 W/AUL_PAD (12794): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.clover)
05-25 17:22:45.321+0900 I/CAPI_APPFW_APPLICATION(12794): app_main.c: ui_app_main(704) > app_efl_main
05-25 17:22:45.321+0900 I/CAPI_APPFW_APPLICATION(12794): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-25 17:22:45.361+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.clover) pid(12794) type(uiapp) bg(0)
05-25 17:22:45.361+0900 W/AUL_AMD ( 2490): amd_status.c: __socket_monitor_cb(1277) > (12794) was created
05-25 17:22:45.361+0900 W/AUL     (12871): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12794)
05-25 17:22:45.371+0900 W/STARTER ( 2650): pkg-monitor.c: _app_mgr_status_cb(394) > [_app_mgr_status_cb:394] Launch request [12794]
05-25 17:22:45.451+0900 E/EFL     (12794): ecore_evas<12794> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-25 17:22:45.461+0900 W/W_HOME  ( 2724): event_manager.c: _ecore_x_message_cb(428) > state: 0 -> 1
05-25 17:22:45.461+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:22:45.461+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:22:45.461+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:22:45.461+0900 W/W_HOME  ( 2724): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 0
05-25 17:22:45.471+0900 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
05-25 17:22:45.471+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
05-25 17:22:45.541+0900 E/EFL     (12794): elementary<12794> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
05-25 17:22:45.561+0900 E/EFL     (12794): elementary<12794> elc_naviframe.c:2950 elm_naviframe_item_push() item(0xf2f2c900) will be pushed
05-25 17:22:45.601+0900 E/TIZEN_N_RECORDER(12794): recorder.c: __convert_recorder_error_code(193) > [audio-channel] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:22:45.601+0900 E/TIZEN_N_RECORDER(12794): recorder.c: __convert_recorder_error_code(193) > [audio-device] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:22:45.601+0900 I/APP_CORE(12794): appcore-efl.c: __do_app(453) > [APP 12794] Event: RESET State: CREATED
05-25 17:22:45.601+0900 I/CAPI_APPFW_APPLICATION(12794): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-25 17:22:45.611+0900 I/APP_CORE(12794): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
05-25 17:22:45.611+0900 I/APP_CORE(12794): appcore-efl.c: __do_app(524) > [APP 12794] Initial Launching, call the resume_cb
05-25 17:22:45.621+0900 I/CAPI_APPFW_APPLICATION(12794): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-25 17:22:45.621+0900 W/APP_CORE(12794): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3600002
05-25 17:22:45.691+0900 W/W_HOME  ( 2724): event_manager.c: _window_visibility_cb(473) > Window [0x1E00003] is now visible(1)
05-25 17:22:45.691+0900 W/W_HOME  ( 2724): event_manager.c: _window_visibility_cb(483) > state: 1 -> 0
05-25 17:22:45.691+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:22:45.691+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:22:45.691+0900 W/W_HOME  ( 2724): main.c: _window_visibility_cb(964) > Window [0x1E00003] is now visible(1)
05-25 17:22:45.691+0900 I/APP_CORE(12794): appcore-efl.c: __visibility_cb(937) > LCD status is off, skip the AE_RESUME event
05-25 17:22:45.691+0900 I/APP_CORE( 2724): appcore-efl.c: __do_app(453) > [APP 2724] Event: PAUSE State: RUNNING
05-25 17:22:45.691+0900 I/CAPI_APPFW_APPLICATION( 2724): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-25 17:22:45.691+0900 W/W_HOME  ( 2724): main.c: _appcore_pause_cb(488) > appcore pause
05-25 17:22:45.691+0900 E/W_HOME  ( 2724): main.c: _pause_cb(466) > paused already
05-25 17:22:45.691+0900 I/APP_CORE( 2724): appcore-efl.c: __visibility_cb(949) > LCD status is off, skip the AE_RESUME event
05-25 17:22:45.691+0900 I/wnotib  ( 2724): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
05-25 17:22:45.691+0900 E/wnotib  ( 2724): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-25 17:22:45.691+0900 W/wnotib  ( 2724): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [3], notiboard card appending count [9].
05-25 17:22:45.711+0900 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2724] goes to (4)
05-25 17:22:45.711+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2724) status(bg) type(uiapp)
05-25 17:22:45.711+0900 E/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2724)'s state(4)
05-25 17:22:45.711+0900 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[12794] goes to (3)
05-25 17:22:45.721+0900 W/AUL_AMD ( 2490): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-25 17:22:45.721+0900 W/AUL_AMD ( 2490): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
05-25 17:22:45.721+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.clover) pid(12794) status(fg) type(uiapp)
05-25 17:22:46.061+0900 E/AUL     ( 2490): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
05-25 17:22:46.471+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 14
05-25 17:22:46.481+0900 W/AUL_AMD ( 2490): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12794
05-25 17:22:46.481+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 12
05-25 17:22:46.481+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 14
05-25 17:22:46.491+0900 W/AUL_AMD ( 2490): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12794
05-25 17:22:46.501+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 12
05-25 17:22:46.681+0900 I/AUL_PAD (12876): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
05-25 17:22:49.961+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [5015.305114] dpms[3 -> 0]sync[0]
05-25 17:22:49.961+0900 I/TDM     ( 1552): 
05-25 17:22:49.961+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [5015.305338] dpms[0 -> 0]done
05-25 17:22:49.961+0900 I/TDM     ( 1552): 
05-25 17:22:50.011+0900 W/wnotibp ( 3231): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(91) > ::APP:: view state=0, 2, 0
05-25 17:22:50.011+0900 I/wnotibp ( 3231): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(140) > There is no additional work.
05-25 17:22:50.021+0900 W/WATCH_CORE( 2779): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOn
05-25 17:22:50.021+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_lcd_status_handler(1250) > Call the time_tick_cb
05-25 17:22:50.021+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:22:50.021+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_lcd_status_handler(1257) > Call widget_provider_update_event
05-25 17:22:50.021+0900 W/W_HOME  ( 2724): dbus.c: _dbus_message_recv_cb(186) > LCD on
05-25 17:22:50.021+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_disable_timer_set(167) > timer set
05-25 17:22:50.021+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_disable_timer_del(157) > timer del
05-25 17:22:50.021+0900 W/W_HOME  ( 2724): gesture.c: _apps_status_get(128) > apps status:0
05-25 17:22:50.021+0900 W/W_HOME  ( 2724): gesture.c: _lcd_on_cb(303) > move_to_clock:1 clock_visible:0 info->offtime:125464
05-25 17:22:50.021+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_schedule(209) > schedule, manual render
05-25 17:22:50.021+0900 W/W_HOME  ( 2724): event_manager.c: _lcd_on_cb(728) > lcd state: 1
05-25 17:22:50.021+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:22:50.021+0900 W/STARTER ( 2650): clock-mgr.c: _on_lcd_signal_receive_cb(1579) > [_on_lcd_signal_receive_cb:1579] _on_lcd_signal_receive_cb, 1579, Pre LCD on by [powerkey] after screen off time [125464]ms
05-25 17:22:50.021+0900 W/STARTER ( 2650): clock-mgr.c: _pre_lcd_on(1298) > [_pre_lcd_on:1298] Will LCD ON as reserved app[(null)] alpm mode[0]
05-25 17:22:50.031+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_set_info(1442) > [5015.373325] layer(0x874fb8) not usable
05-25 17:22:50.031+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_set_info(1459) > [5015.373387] layer(0x874fb8) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
05-25 17:22:50.031+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_layer_set_info(1578) > [5015.373414] layer[0x874b08]zpos[1]
05-25 17:22:50.031+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_set_info(1442) > [5015.373558] layer(0x875008) not usable
05-25 17:22:50.031+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_set_info(1459) > [5015.373576] layer(0x875008) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
05-25 17:22:50.031+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_layer_set_info(1578) > [5015.373598] layer[0x874c28]zpos[2]
05-25 17:22:50.041+0900 I/APP_CORE(12794): appcore-efl.c: __do_app(453) > [APP 12794] Event: RESUME State: RUNNING
05-25 17:22:50.071+0900 W/W_INDICATOR( 2651): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(285) > [_windicator_dbus_lcd_changed_cb:285] LCD ON signal is received
05-25 17:22:50.071+0900 W/W_INDICATOR( 2651): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] 304, str=[powerkey],charge : 0, connected : 0
05-25 17:22:50.071+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : -147223796[0;m
05-25 17:22:50.071+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
05-25 17:22:50.071+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-25 17:22:50.071+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
05-25 17:22:50.071+0900 W/W_HOME  ( 2724): gesture.c: _widget_updated_cb(188) > widget updated
05-25 17:22:50.071+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_disable_timer_del(157) > timer del
05-25 17:22:50.071+0900 W/W_HOME  ( 2724): gesture.c: _manual_render(182) > 
05-25 17:22:50.081+0900 W/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
05-25 17:22:50.081+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
05-25 17:22:50.081+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
05-25 17:22:50.081+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
05-25 17:22:50.091+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
05-25 17:22:50.091+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
05-25 17:22:50.091+0900 W/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-25 17:22:50.091+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
05-25 17:22:50.091+0900 I/HIGEAR  ( 3216): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
05-25 17:22:50.101+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
05-25 17:22:50.101+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
05-25 17:22:50.101+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: preference_get_boolean(1173) > preference_get_boolean(3233) : test_healthy_pace error
05-25 17:22:50.101+0900 W/SHealthService( 3233): ContextPedometerProxy.cpp: OnContextStepLevelMonitorUpdated(1142) > [1;40;33mOnNotWearingStart[0;m
05-25 17:22:50.121+0900 W/W_HOME  ( 2724): gesture.c: _manual_render(182) > 
05-25 17:22:50.161+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_enable(138) > 0
05-25 17:22:50.201+0900 W/SHealthCommon( 3233): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1495670400000.000000[0;m
05-25 17:22:50.221+0900 W/SHealthCommon( 3233): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_session_updated client list: [2:com.samsung.shealth.widget.hrlog (916859)]][0;m
05-25 17:22:50.231+0900 W/SHealthCommon( 2843): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:1[0;m
05-25 17:22:50.231+0900 W/STARTER ( 2650): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [powerkey]
05-25 17:22:50.231+0900 W/STARTER ( 2650): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[0]
05-25 17:22:50.261+0900 W/SHealthWidget( 2843): WidgetMain.cpp: widget_update(147) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.widget.hrlog (916859), msgName: timeline_session_updated[0;m
05-25 17:22:50.261+0900 W/SHealthCommon( 2843): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_session_updated[0;m
05-25 17:22:50.261+0900 W/SHealthWidget( 2843): HrLogWidgetViewController.cpp: OnIpcProxyMessageReceived(75) > [1;35m##24Hour Widget Service SessionUpdate Called[0;m
05-25 17:22:50.271+0900 W/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1495732970279.000000, pattern:[HH:mm][0;m
05-25 17:22:50.271+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-25 17:22:50.271+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-25 17:22:50.271+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-25 17:22:50.271+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-25 17:22:50.271+0900 E/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale ko_KR[0;m
05-25 17:22:50.271+0900 W/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:22][0;m
05-25 17:22:50.271+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-25 17:22:50.271+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-25 17:22:50.271+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-25 17:22:50.271+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-25 17:22:50.271+0900 W/SHealthAppCommon( 2843): TodayLogItemDataGenerator.cpp: CreateDataList(84) > [1;35m BEGIN >>>>[0;m
05-25 17:22:50.271+0900 W/SHealthCommon( 3233): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.1.30][0;m
05-25 17:22:50.271+0900 W/SHealthCommon( 3233): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:1[0;m
05-25 17:22:50.271+0900 W/SHealthService( 3233): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-25 17:22:50.281+0900 W/SHealthAppCommon( 2843): TodayLogItemDataGenerator.cpp: PushSessionEvent(157) > [1;35mTIMELINE :: NOTWEARING Time[2017/5/25 0:0:0 ~ 2017/5/25 15:42:50], Calorie :[1061.821644][0;m
05-25 17:22:50.281+0900 W/SHealthAppCommon( 2843): TodayLogItemDataGenerator.cpp: PushSessionEvent(154) > [1;35mTIMELINE :: LIGHT Time[2017/5/25 15:42:50 ~ 2017/5/25 15:43:50], Calorie :[1.126925][0;m
05-25 17:22:50.281+0900 W/SHealthAppCommon( 2843): TodayLogItemDataGenerator.cpp: PushSessionEvent(157) > [1;35mTIMELINE :: NOTWEARING Time[2017/5/25 15:43:50 ~ 2017/5/25 16:51:45], Calorie :[76.479733][0;m
05-25 17:22:50.281+0900 W/SHealthAppCommon( 2843): TodayLogItemDataGenerator.cpp: PushSessionEvent(154) > [1;35mTIMELINE :: LIGHT Time[2017/5/25 16:51:45 ~ 2017/5/25 16:53:6], Calorie :[1.520605][0;m
05-25 17:22:50.291+0900 W/SHealthAppCommon( 2843): TodayLogItemDataGenerator.cpp: PushSessionEvent(157) > [1;35mTIMELINE :: NOTWEARING Time[2017/5/25 16:53:6 ~ 2017/5/25 17:17:44], Calorie :[27.740819][0;m
05-25 17:22:50.291+0900 W/SHealthAppCommon( 2843): TodayLogItemDataGenerator.cpp: PushSessionEvent(154) > [1;35mTIMELINE :: LIGHT Time[2017/5/25 17:17:44 ~ 2017/5/25 17:21:26], Calorie :[4.168228][0;m
05-25 17:22:50.291+0900 W/SHealthAppCommon( 2843): TodayLogItemDataGenerator.cpp: PushSessionEvent(157) > [1;35mTIMELINE :: NOTWEARING Time[2017/5/25 17:21:26 ~ 2017/5/25 17:22:50], Calorie :[1.578885][0;m
05-25 17:22:50.291+0900 W/SHealthAppCommon( 2843): TodayLogItemDataGenerator.cpp: CreateDataList(112) > [1;35m END <<<<[0;m
05-25 17:22:50.291+0900 I/CAPI_WIDGET_APPLICATION( 2843): widget_app.c: __provider_update_cb(281) > received updating signal
05-25 17:22:50.321+0900 W/SHealthCommon( 3233): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.widget.hrlog (916859)]][0;m
05-25 17:22:50.351+0900 W/SHealthCommon( 3233): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.1.30][0;m
05-25 17:22:50.351+0900 W/SHealthCommon( 3233): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1495670400000.000000[0;m
05-25 17:22:50.361+0900 W/SHealthWidget( 2843): WidgetMain.cpp: widget_update(147) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.widget.hrlog (916859), msgName: timeline_summary_updated[0;m
05-25 17:22:50.361+0900 W/SHealthCommon( 2843): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
05-25 17:22:50.361+0900 W/SHealthWidget( 2843): HrLogWidgetViewController.cpp: OnIpcProxyMessageReceived(71) > [1;35m##24Hour Widget Service SummaryUpdate Called[0;m
05-25 17:22:50.361+0900 W/SHealthCommon( 2843): DBConnector.cpp: DbUtilBusyHandler(159) > [1;40;33mBusy Handler Called! : CNT(1)
05-25 17:22:50.361+0900 W/SHealthCommon( 2843): [0;m
05-25 17:22:50.371+0900 I/HealthDataService( 2909): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-25 17:22:50.381+0900 I/healthData( 3233): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
05-25 17:22:50.381+0900 W/SHealthCommon( 3233): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.widget.hrlog (916859)]][0;m
05-25 17:22:50.411+0900 W/SHealthCommon( 3233): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.1.30][0;m
05-25 17:22:50.411+0900 I/HealthDataService( 2909): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-25 17:22:50.431+0900 I/healthData( 3233): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
05-25 17:22:50.471+0900 W/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1495732970480.000000, pattern:[HH:mm][0;m
05-25 17:22:50.471+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-25 17:22:50.471+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-25 17:22:50.471+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-25 17:22:50.471+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-25 17:22:50.471+0900 E/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale ko_KR[0;m
05-25 17:22:50.471+0900 W/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:22][0;m
05-25 17:22:50.471+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-25 17:22:50.471+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-25 17:22:50.471+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-25 17:22:50.471+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-25 17:22:50.471+0900 I/CAPI_WIDGET_APPLICATION( 2843): widget_app.c: __provider_update_cb(281) > received updating signal
05-25 17:22:50.511+0900 W/WATCH_CORE( 2779): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
05-25 17:22:50.511+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
05-25 17:22:50.511+0900 W/W_HOME  ( 2724): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-25 17:22:50.511+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:22:50.521+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: OnReceiveGestureChanged(995) > [0;32mINFO: wakeup receive data : -145485408[0;m
05-25 17:22:50.521+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: OnReceiveGestureChanged(996) > [0;32mINFO: WakeupServiceStart[0;m
05-25 17:22:50.521+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-25 17:22:50.521+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
05-25 17:22:50.521+0900 W/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
05-25 17:22:50.531+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
05-25 17:22:50.531+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
05-25 17:22:50.531+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
05-25 17:22:50.541+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
05-25 17:22:50.541+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
05-25 17:22:50.541+0900 W/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-25 17:22:50.541+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
05-25 17:22:50.541+0900 I/HIGEAR  ( 3216): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
05-25 17:22:50.571+0900 W/SHealthWidget( 2843): WidgetMain.cpp: widget_update(147) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.widget.hrlog (916859), msgName: timeline_summary_updated[0;m
05-25 17:22:50.571+0900 W/SHealthCommon( 2843): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
05-25 17:22:50.571+0900 W/SHealthWidget( 2843): HrLogWidgetViewController.cpp: OnIpcProxyMessageReceived(71) > [1;35m##24Hour Widget Service SummaryUpdate Called[0;m
05-25 17:22:50.571+0900 W/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1495732970584.000000, pattern:[HH:mm][0;m
05-25 17:22:50.571+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-25 17:22:50.571+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-25 17:22:50.571+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-25 17:22:50.571+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-25 17:22:50.571+0900 E/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale ko_KR[0;m
05-25 17:22:50.571+0900 W/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:22][0;m
05-25 17:22:50.571+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-25 17:22:50.571+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-25 17:22:50.571+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-25 17:22:50.571+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-25 17:22:50.571+0900 I/CAPI_WIDGET_APPLICATION( 2843): widget_app.c: __provider_update_cb(281) > received updating signal
05-25 17:22:50.691+0900 I/APP_CORE( 2724): appcore-efl.c: __do_app(453) > [APP 2724] Event: MEM_FLUSH State: PAUSED
05-25 17:22:50.911+0900 E/EFL     (12794): ecore_x<12794> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5016257 button=1
05-25 17:22:51.011+0900 E/EFL     (12794): ecore_x<12794> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5016353 button=1
05-25 17:22:51.091+0900 I/USR_TAG (12794): record_start
05-25 17:22:51.091+0900 E/TIZEN_N_RECORDER(12794): recorder.c: __convert_recorder_error_code(193) > [recorder_attr_set_time_limit] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:22:51.091+0900 E/TIZEN_N_RECORDER(12794): recorder.c: __convert_recorder_error_code(193) > [recorder_set_filename] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:22:51.091+0900 E/TIZEN_N_RECORDER(12794): recorder.c: __convert_recorder_error_code(193) > [file-format] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:22:51.091+0900 E/TIZEN_N_RECORDER(12794): recorder.c: __convert_recorder_error_code(193) > [audio-encoder] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:22:51.391+0900 E/TIZEN_N_RECORDER(12794): recorder.c: __convert_recorder_error_code(193) > [recorder_start] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:22:51.391+0900 E/EFL     (12794): <12794> elm_main.c:1300 elm_object_disabled_set() safety check failed: obj == NULL
05-25 17:22:51.391+0900 E/EFL     (12794): <12794> elm_main.c:1300 elm_object_disabled_set() safety check failed: obj == NULL
05-25 17:22:51.401+0900 E/EFL     (12794): elementary<12794> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
05-25 17:22:51.411+0900 E/EFL     (12794): elementary<12794> elc_naviframe.c:2950 elm_naviframe_item_push() item(0xf2fa9be0) will be pushed
05-25 17:22:51.421+0900 E/EFL     (12794): elementary<12794> elc_naviframe.c:2796 _push_transition_cb() item(0xf2fa9be0) will transition
05-25 17:22:51.851+0900 E/EFL     (12794): elementary<12794> elc_naviframe.c:1193 _on_item_push_finished() item(0xf2f2c900) transition finished
05-25 17:22:51.851+0900 E/EFL     (12794): elementary<12794> elc_naviframe.c:1218 _on_item_show_finished() item(0xf2fa9be0) transition finished
05-25 17:22:52.011+0900 E/EFL     ( 2318): ecore_x<2318> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x3600002 time=5016764
05-25 17:22:52.021+0900 E/EFL     (12794): ecore_x<12794> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=5016764
05-25 17:22:52.021+0900 E/EFL     ( 2318): ecore_x<2318> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=5016764
05-25 17:22:52.391+0900 I/USR_TAG (12794): loud sound is detected!
05-25 17:22:52.701+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 12794 pgid = 12794
05-25 17:22:52.701+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
05-25 17:22:52.751+0900 W/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
05-25 17:22:52.751+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
05-25 17:22:52.751+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:22:52.761+0900 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2724] goes to (3)
05-25 17:22:52.761+0900 E/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2724)'s state(3)
05-25 17:22:52.761+0900 W/AUL_AMD ( 2490): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-25 17:22:52.761+0900 W/AUL_AMD ( 2490): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
05-25 17:22:52.761+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2724) status(fg) type(uiapp)
05-25 17:22:52.801+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
05-25 17:22:52.801+0900 I/AUL_AMD ( 2490): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 12794
05-25 17:22:52.801+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(12794)
05-25 17:22:52.821+0900 W/PROCESSMGR( 2318): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
05-25 17:22:52.821+0900 W/W_HOME  ( 2724): event_manager.c: _ecore_x_message_cb(428) > state: 1 -> 0
05-25 17:22:52.821+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:22:52.821+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:22:52.821+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:22:52.821+0900 W/W_HOME  ( 2724): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
05-25 17:22:52.821+0900 W/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
05-25 17:22:52.821+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
05-25 17:22:52.821+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:22:52.831+0900 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
05-25 17:22:52.851+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
05-25 17:22:52.861+0900 W/W_HOME  ( 2724): event_manager.c: _window_visibility_cb(473) > Window [0x1E00003] is now visible(0)
05-25 17:22:52.861+0900 W/W_HOME  ( 2724): event_manager.c: _window_visibility_cb(483) > state: 0 -> 1
05-25 17:22:52.861+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:22:52.861+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:22:52.861+0900 W/W_HOME  ( 2724): main.c: _window_visibility_cb(964) > Window [0x1E00003] is now visible(0)
05-25 17:22:52.861+0900 I/APP_CORE( 2724): appcore-efl.c: __do_app(453) > [APP 2724] Event: RESUME State: PAUSED
05-25 17:22:52.861+0900 I/CAPI_APPFW_APPLICATION( 2724): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-25 17:22:52.861+0900 W/W_HOME  ( 2724): main.c: _appcore_resume_cb(479) > appcore resume
05-25 17:22:52.861+0900 W/W_HOME  ( 2724): event_manager.c: _app_resume_cb(380) > state: 2 -> 1
05-25 17:22:52.861+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:22:52.861+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:22:52.861+0900 W/W_HOME  ( 2724): main.c: home_resume(527) > journal_multimedia_screen_loaded_home called
05-25 17:22:52.861+0900 W/W_HOME  ( 2724): main.c: home_resume(531) > clock/widget resumed
05-25 17:22:52.861+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:22:52.861+0900 I/wnotib  ( 2724): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 0
05-25 17:22:52.861+0900 E/wnotib  ( 2724): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-25 17:22:52.861+0900 W/wnotib  ( 2724): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
05-25 17:22:52.881+0900 W/WATCH_CORE( 2779): appcore-watch.c: __widget_resume(1124) > widget_resume
05-25 17:22:52.881+0900 W/AUL     ( 2779): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.chronograph16) pid(2779) status(fg) type(watchapp)
05-25 17:22:52.881+0900 D/chronograph( 2779): ChronographApp.cpp: _appResume(161) > [0;34m>>>HIT<<<[0;m
05-25 17:22:52.881+0900 D/chronograph( 2779): ChronographViewController.cpp: onResume(221) > State is Resume[isPaused=0], StopwatchState=0
05-25 17:22:52.881+0900 W/chronograph( 2779): ChronographSweepSecond.cpp: setSweepSecond(55) > [0;35msetSweepSecond >>>>[0;m
05-25 17:22:52.881+0900 D/chronograph( 2779): ChronographSweepSecond.cpp: setSweepSecond(67) > Current sec = 52, msec = 892
05-25 17:22:52.881+0900 D/chronograph( 2779): ChronographSweepSecond.cpp: setSweepSecond(71) > Create sweepSecondAnimation !!
05-25 17:22:52.881+0900 D/chronograph-common( 2779): ChronographSensor.cpp: enableAccelerometer(44) > [0;32mBEGIN >>>>[0;m
05-25 17:22:52.881+0900 D/chronograph-common( 2779): ChronographSensor.cpp: _startAccelerometer(75) > [0;32mBEGIN >>>>[0;m
05-25 17:22:52.921+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:22:52.931+0900 W/CRASH_MANAGER(12917): worker.c: worker_job(1199) > 1112794636c6f149570057

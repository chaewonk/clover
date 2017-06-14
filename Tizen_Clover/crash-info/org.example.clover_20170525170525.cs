S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.1
Build-Number: R760XXU1APL2
Build-Date: 2016.12.20 22:57:01

Crash Information
Process Name: clover
PID: 9986
Date: 2017-05-25 17:05:25+0900
Executable File Path: /opt/usr/apps/org.example.clover/bin/clover
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 9986, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0xf5c4226c, r3   = 0x00000001
r4   = 0xf700a9b8, r5   = 0xf700a9b8
r6   = 0xf700a16c, r7   = 0xff833b00
r8   = 0xf700a9b8, r9   = 0xf7ab2b80
r10  = 0xf7018b10, fp   = 0x00000000
ip   = 0xf5c422ac, sp   = 0xff833ab8
lr   = 0xf6dce5d0, pc   = 0xf5c2e562
cpsr = 0x60000030

Memory Information
MemTotal:   714608 KB
MemFree:      6808 KB
Buffers:     35848 KB
Cached:     172920 KB
VmPeak:     190456 KB
VmSize:     190452 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       37348 KB
VmRSS:       37344 KB
VmData:     112412 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       29384 KB
VmPTE:         184 KB
VmSwap:          0 KB

Threads Information
Threads: 11
PID = 9986 TID = 9986
9986 9995 9996 9999 10000 10001 10002 10003 10004 10005 10006 

Maps Information
ed081000 ed880000 rw-p [stack:10006]
ed881000 ee481000 rw-p [stack:10005]
ee482000 eec81000 rw-p [stack:10004]
eec82000 ef481000 rw-p [stack:10003]
efc84000 f0483000 rw-p [stack:10002]
f0484000 f0c83000 rw-p [stack:10001]
f0c83000 f0c86000 r-xp /usr/lib/gstreamer-0.10/libgstwavenc.so
f0c8e000 f0ca8000 r-xp /usr/lib/gstreamer-0.10/libgstpulse.so
f0cb1000 f0ce9000 r-xp /usr/lib/libsamrnb.so
f0d0c000 f0d17000 r-xp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
f0d20000 f0d30000 r-xp /usr/lib/gstreamer-0.10/libgstalsa.so
f0d38000 f0d3e000 r-xp /usr/lib/libscmn.so
f0d46000 f0d7e000 r-xp /usr/lib/libsaac.so
f0d88000 f0d8d000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencamrnb.so
f0d95000 f0da5000 r-xp /usr/lib/lib_SamsungRec_TizenV04015.so
f0dc6000 f0dce000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
f0ddd000 f0de2000 r-xp /usr/lib/gstreamer-0.10/libgstsecrecord.so
f0df4000 f0e0c000 r-xp /usr/lib/libgstcontroller-0.10.so.0.30.0
f0e1c000 f0e22000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencaac.so
f0e2a000 f0e42000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
f0e4b000 f0e74000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
f0e86000 f0e8b000 r-xp /usr/lib/gstreamer-0.10/libgstvolume.so
f0e93000 f0ff1000 r-xp /usr/lib/gstreamer-0.10/libgstffmpeg.so
f10d9000 f10e5000 r-xp /usr/lib/gstreamer-0.10/libgstencodebin.so
f10ed000 f110d000 r-xp /usr/lib/gstreamer-0.10/libgstomx.so
f110e000 f1142000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
f114b000 f1156000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
f115e000 f1160000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
f1168000 f1169000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
f1171000 f1179000 r-xp /usr/lib/libfeedback.so.0.1.4
f117e000 f1181000 r-xp /usr/lib/gstreamer-0.10/libgstavsysaudiosrc.so
f1189000 f118a000 r-xp /usr/lib/gstreamer-0.10/libgstapp.so
f1192000 f1193000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
f129a000 f1a99000 rw-p [stack:9996]
f1a9a000 f2299000 rw-p [stack:9995]
f2341000 f2b40000 rw-p [stack:9999]
f2b40000 f2b41000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
f2d88000 f3587000 rw-p [stack:10000]
f3587000 f3589000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
f3591000 f35a8000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f35b5000 f35ba000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f35c2000 f35cd000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f3907000 f39f9000 r-xp /usr/lib/libCOREGL.so.4.0
f3a12000 f3a17000 r-xp /usr/lib/libsystem.so.0.0.0
f3a21000 f3a22000 r-xp /usr/lib/libresponse.so.0.2.96
f3a2a000 f3a2f000 r-xp /usr/lib/libproc-stat.so.0.2.96
f3a38000 f3a3a000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f3a42000 f3a49000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f3a52000 f3a74000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f3a7d000 f3a81000 r-xp /usr/lib/libogg.so.0.7.1
f3a89000 f3aab000 r-xp /usr/lib/libvorbis.so.0.4.3
f3ab3000 f3ab6000 r-xp /usr/lib/libtinycompress.so.0.0.0
f3abe000 f3acd000 r-xp /usr/lib/libmdm-common.so.1.1.22
f3ad6000 f3ade000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f3ae6000 f3aec000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f3af5000 f3afc000 r-xp /usr/lib/libminizip.so.1.0.0
f3b04000 f3b06000 r-xp /usr/lib/libttrace.so.1.1
f3b0e000 f3b55000 r-xp /usr/lib/libsndfile.so.1.0.26
f3b61000 f3baa000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f3bb3000 f3bb8000 r-xp /usr/lib/libjson.so.0.0.1
f5451000 f5557000 r-xp /usr/lib/libicuuc.so.57.1
f556d000 f56f5000 r-xp /usr/lib/libicui18n.so.57.1
f5705000 f5712000 r-xp /usr/lib/libail.so.0.1.0
f571b000 f571e000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f5726000 f5729000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f5731000 f5792000 r-xp /usr/lib/libasound.so.2.0.0
f579c000 f57b2000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f57ba000 f57be000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f57c6000 f5807000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
f5810000 f5812000 r-xp /usr/lib/libdri2.so.0.0.0
f581a000 f5822000 r-xp /usr/lib/libdrm.so.2.4.0
f582a000 f5830000 r-xp /usr/lib/libxcb-render.so.0.0.0
f5838000 f5839000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f5842000 f5846000 r-xp /usr/lib/libEGL.so.1.4
f5856000 f5867000 r-xp /usr/lib/libGLESv2.so.2.0
f5877000 f58bf000 r-xp /usr/lib/libmdm.so.1.2.62
f58c0000 f58c7000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f58cf000 f58da000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f58e7000 f5900000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f5908000 f590d000 r-xp /usr/lib/libstorage.so.0.1
f5915000 f591a000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f5922000 f595a000 r-xp /usr/lib/libpulse.so.0.16.2
f595b000 f595f000 r-xp /usr/lib/libmmfsession.so.0.0.0
f5968000 f597f000 r-xp /usr/lib/libmmfsound.so.0.1.0
f5991000 f59b2000 r-xp /usr/lib/libexif.so.12.3.3
f59c5000 f59ce000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
f59d6000 f59e3000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
f59ec000 f59f7000 r-xp /usr/lib/libtbm.so.1.0.0
f59ff000 f5a04000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f5a0c000 f5ac4000 r-xp /usr/lib/libcairo.so.2.11200.14
f5acf000 f5b6a000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
f5b76000 f5bc6000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
f5bcc000 f5bde000 r-xp /usr/lib/libcapi-media-camera.so.0.1.35
f5be6000 f5c07000 r-xp /usr/lib/libefl-extension.so.0.1.0
f5c0f000 f5c14000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5c1c000 f5c24000 r-xp /usr/lib/libcapi-media-recorder.so.0.1.28
f5c2c000 f5c33000 r-xp /opt/usr/apps/org.example.clover/bin/clover
f5dd5000 f5ddf000 r-xp /lib/libnss_files-2.13.so
f5de8000 f5eb7000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f5ecd000 f5ef1000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f5efa000 f5f00000 r-xp /usr/lib/libappsvc.so.0.1.0
f5f08000 f5f0a000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f5f13000 f5f17000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f5f23000 f5f2e000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f5f36000 f5f38000 r-xp /usr/lib/libiniparser.so.0
f5f41000 f5f46000 r-xp /usr/lib/libappcore-common.so.1.1
f5f4e000 f5f50000 r-xp /usr/lib/libcamsrcjpegenc.so.0.0.0
f5f58000 f5f5c000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f5f69000 f5f6b000 r-xp /usr/lib/libXau.so.6.0.0
f5f73000 f5f7a000 r-xp /lib/libcrypt-2.13.so
f5faa000 f5fac000 r-xp /usr/lib/libiri.so
f5fb5000 f615e000 r-xp /usr/lib/libcrypto.so.1.0.0
f617e000 f61c5000 r-xp /usr/lib/libssl.so.1.0.0
f61d1000 f61ff000 r-xp /usr/lib/libidn.so.11.5.44
f6207000 f6210000 r-xp /usr/lib/libcares.so.2.1.0
f621a000 f622d000 r-xp /usr/lib/libxcb.so.1.1.0
f6236000 f6238000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6240000 f6242000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f624b000 f6317000 r-xp /usr/lib/libxml2.so.2.7.8
f6324000 f6326000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f632f000 f6334000 r-xp /usr/lib/libffi.so.5.0.10
f633c000 f633d000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6345000 f6348000 r-xp /lib/libattr.so.1.1.0
f6350000 f63e4000 r-xp /usr/lib/libstdc++.so.6.0.16
f63f7000 f6414000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f641e000 f6436000 r-xp /usr/lib/libpng12.so.0.50.0
f643e000 f6454000 r-xp /lib/libexpat.so.1.6.0
f645e000 f64a2000 r-xp /usr/lib/libcurl.so.4.3.0
f64ab000 f64b5000 r-xp /usr/lib/libXext.so.6.4.0
f64be000 f64c2000 r-xp /usr/lib/libXtst.so.6.1.0
f64ca000 f64d0000 r-xp /usr/lib/libXrender.so.1.3.0
f64d8000 f64de000 r-xp /usr/lib/libXrandr.so.2.2.0
f64e6000 f64e7000 r-xp /usr/lib/libXinerama.so.1.0.0
f64f0000 f64f9000 r-xp /usr/lib/libXi.so.6.1.0
f6501000 f6504000 r-xp /usr/lib/libXfixes.so.3.1.0
f650c000 f650e000 r-xp /usr/lib/libXgesture.so.7.0.0
f6516000 f6518000 r-xp /usr/lib/libXcomposite.so.1.0.0
f6520000 f6522000 r-xp /usr/lib/libXdamage.so.1.1.0
f652a000 f6531000 r-xp /usr/lib/libXcursor.so.1.0.2
f6539000 f653c000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f6544000 f6548000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f6551000 f6556000 r-xp /usr/lib/libecore_fb.so.1.7.99
f655f000 f6640000 r-xp /usr/lib/libX11.so.6.3.0
f664b000 f666e000 r-xp /usr/lib/libjpeg.so.8.0.2
f6686000 f669c000 r-xp /lib/libz.so.1.2.5
f66a4000 f66a6000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f66ae000 f6723000 r-xp /usr/lib/libsqlite3.so.0.8.6
f672d000 f6747000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f674f000 f6783000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f678c000 f685f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f686a000 f687a000 r-xp /lib/libresolv-2.13.so
f687e000 f6896000 r-xp /usr/lib/liblzma.so.5.0.3
f689e000 f68a1000 r-xp /lib/libcap.so.2.21
f68a9000 f68d8000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f68e0000 f68e1000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f68e9000 f68ef000 r-xp /usr/lib/libecore_imf.so.1.7.99
f68f7000 f690e000 r-xp /usr/lib/liblua-5.1.so
f6917000 f691e000 r-xp /usr/lib/libembryo.so.1.7.99
f6926000 f692c000 r-xp /lib/librt-2.13.so
f6935000 f698b000 r-xp /usr/lib/libpixman-1.so.0.28.2
f6998000 f69ee000 r-xp /usr/lib/libfreetype.so.6.11.3
f69fa000 f6a22000 r-xp /usr/lib/libfontconfig.so.1.8.0
f6a23000 f6a68000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6a71000 f6a84000 r-xp /usr/lib/libfribidi.so.0.3.1
f6a8c000 f6aa6000 r-xp /usr/lib/libecore_con.so.1.7.99
f6aaf000 f6ab8000 r-xp /usr/lib/libedbus.so.1.7.99
f6ac0000 f6b10000 r-xp /usr/lib/libecore_x.so.1.7.99
f6b12000 f6b1b000 r-xp /usr/lib/libvconf.so.0.2.45
f6b23000 f6b34000 r-xp /usr/lib/libecore_input.so.1.7.99
f6b3c000 f6b41000 r-xp /usr/lib/libecore_file.so.1.7.99
f6b49000 f6b6b000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6b74000 f6bb5000 r-xp /usr/lib/libeina.so.1.7.99
f6bbe000 f6bd7000 r-xp /usr/lib/libeet.so.1.7.99
f6be8000 f6c51000 r-xp /lib/libm-2.13.so
f6c5a000 f6c60000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c69000 f6c6a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c72000 f6c95000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c9d000 f6ca2000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6caa000 f6cd4000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6cdd000 f6cf4000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6cfc000 f6d07000 r-xp /lib/libunwind.so.8.0.1
f6d34000 f6d52000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d5c000 f6e80000 r-xp /lib/libc-2.13.so
f6e8e000 f6e96000 r-xp /lib/libgcc_s-4.6.so.1
f6e97000 f6e9b000 r-xp /usr/lib/libsmack.so.1.0.0
f6ea4000 f6eaa000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f6eb2000 f6f82000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f83000 f6fe1000 r-xp /usr/lib/libedje.so.1.7.99
f6feb000 f7002000 r-xp /usr/lib/libecore.so.1.7.99
f7019000 f70e7000 r-xp /usr/lib/libevas.so.1.7.99
f710c000 f7248000 r-xp /usr/lib/libelementary.so.1.7.99
f725f000 f7273000 r-xp /lib/libpthread-2.13.so
f727e000 f7280000 r-xp /usr/lib/libdlog.so.0.0.0
f7288000 f728b000 r-xp /usr/lib/libbundle.so.0.1.22
f7293000 f7295000 r-xp /lib/libdl-2.13.so
f729e000 f72ab000 r-xp /usr/lib/libaul.so.0.1.0
f72bc000 f72c2000 r-xp /usr/lib/libappcore-efl.so.1.1
f72cb000 f72cf000 r-xp /usr/lib/libsys-assert.so
f72d8000 f72f5000 r-xp /lib/ld-2.13.so
f72fe000 f7303000 r-xp /usr/bin/launchpad-loader
f7a7a000 f7d88000 rw-p [heap]
ff814000 ff835000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9986)
Call Stack Count: 12
 0: ecore_timer_cb + 0xc9 (0xf5c2e562) [/opt/usr/apps/org.example.clover/bin/clover] + 0x2562
 1: (0xf6ffa1f9) [/usr/lib/libecore.so.1] + 0xf1f9
 2: (0xf6ffa2ef) [/usr/lib/libecore.so.1] + 0xf2ef
 3: (0xf6ff72f3) [/usr/lib/libecore.so.1] + 0xc2f3
 4: ecore_main_loop_begin + 0x30 (0xf6ff7879) [/usr/lib/libecore.so.1] + 0xc879
 5: appcore_efl_main + 0x332 (0xf72bfb47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
 6: ui_app_main + 0xb0 (0xf5f5a421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 7: uib_app_run + 0xea (0xf5c2eef3) [/opt/usr/apps/org.example.clover/bin/clover] + 0x2ef3
 8: main + 0x34 (0xf5c2e489) [/opt/usr/apps/org.example.clover/bin/clover] + 0x2489
 9: (0xf72ffa53) [/opt/usr/apps/org.example.clover/bin/clover] + 0x1a53
10: __libc_start_main + 0x114 (0xf6d7385c) [/lib/libc.so.6] + 0x1785c
11: (0xf72ffe0c) [/opt/usr/apps/org.example.clover/bin/clover] + 0x1e0c
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
tePort
05-25 17:05:15.041+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-25 17:05:15.041+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-25 17:05:15.041+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:05:15.041+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-25 17:05:15.041+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-25 17:05:15.041+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-25 17:05:15.041+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-25 17:05:15.051+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
05-25 17:05:15.051+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-25 17:05:15.051+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-25 17:05:15.051+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-25 17:05:15.051+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-25 17:05:15.051+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:05:15.051+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-25 17:05:15.051+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-25 17:05:15.051+0900 W/W_HOME  ( 2724): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-25 17:05:15.051+0900 E/W_HOME  ( 2724): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-25 17:05:15.051+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-25 17:05:15.061+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-25 17:05:15.061+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-25 17:05:15.061+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-25 17:05:15.061+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-25 17:05:15.061+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:05:15.061+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-25 17:05:15.061+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-25 17:05:15.061+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-25 17:05:15.061+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-25 17:05:15.061+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
05-25 17:05:15.061+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-25 17:05:15.061+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-25 17:05:15.061+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-25 17:05:15.061+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-25 17:05:15.061+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:05:15.191+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:05:15.201+0900 W/KEYROUTER( 2318): e_mod_main.c: DeliverDeviceKeyEvents(3168) > Deliver KeyRelease. value=2669, window=0x1e00003
05-25 17:05:15.201+0900 E/EFL     ( 2724): ecore_x<2724> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=3960540
05-25 17:05:15.201+0900 W/wnotib  ( 2724): w-notification-board-broker-main.c: _wnotib_view_event_handler(1308) > Home view event: 0x40000
05-25 17:05:15.201+0900 I/wnotib  ( 2724): w-notification-board-broker-main.c: _wnotib_view_event_handler(1382) > On the cover view. Go to home.
05-25 17:05:15.201+0900 W/W_HOME  ( 2724): noti_broker.c: _noti_broker_back_cb(762) > continue the back key execution
05-25 17:05:15.201+0900 E/W_HOME  ( 2724): cs_broker.c: _cs_broker_back_cb(258) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
05-25 17:05:15.201+0900 W/W_HOME  ( 2724): main.c: _back_key_cb(1386) > emit:signal => key,back,clicked
05-25 17:05:15.201+0900 W/W_HOME  ( 2724): clock_event.c: _back_key_cb(287) > 
05-25 17:05:15.211+0900 W/WATCH_CORE( 2779): appcore-watch.c: __widget_text_signal_cb(1140) > widget_text_signal
05-25 17:05:15.241+0900 W/W_HOME  ( 2724): index.c: index_hide(337) > hide VI:1 visibility:0 vi:(nil)
05-25 17:05:15.391+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:05:15.591+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:05:15.791+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:05:15.991+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:05:16.031+0900 W/KEYROUTER( 2318): e_mod_main.c: DeliverDeviceKeyEvents(3157) > Deliver KeyPress. value=2669, window=0x1e00003
05-25 17:05:16.031+0900 E/EFL     ( 2724): ecore_x<2724> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=3961371
05-25 17:05:16.191+0900 W/KEYROUTER( 2318): e_mod_main.c: DeliverDeviceKeyEvents(3168) > Deliver KeyRelease. value=2669, window=0x1e00003
05-25 17:05:16.191+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:05:16.191+0900 E/EFL     ( 2724): ecore_x<2724> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=3961530
05-25 17:05:16.191+0900 W/wnotib  ( 2724): w-notification-board-broker-main.c: _wnotib_view_event_handler(1308) > Home view event: 0x40000
05-25 17:05:16.191+0900 I/wnotib  ( 2724): w-notification-board-broker-main.c: _wnotib_view_event_handler(1382) > On the cover view. Go to home.
05-25 17:05:16.191+0900 W/W_HOME  ( 2724): noti_broker.c: _noti_broker_back_cb(762) > continue the back key execution
05-25 17:05:16.191+0900 E/W_HOME  ( 2724): cs_broker.c: _cs_broker_back_cb(258) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
05-25 17:05:16.191+0900 W/W_HOME  ( 2724): main.c: _back_key_cb(1386) > emit:signal => key,back,clicked
05-25 17:05:16.191+0900 W/W_HOME  ( 2724): clock_event.c: _back_key_cb(287) > 
05-25 17:05:16.201+0900 W/WATCH_CORE( 2779): appcore-watch.c: __widget_text_signal_cb(1140) > widget_text_signal
05-25 17:05:16.391+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:05:16.591+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:05:16.791+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:05:16.991+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:05:17.101+0900 W/KEYROUTER( 2318): e_mod_main.c: DeliverDeviceKeyEvents(3237) > Deliver KeyPress to focus window. value=1997, window=0x1e00003
05-25 17:05:17.101+0900 W/KEYROUTER( 2318): e_mod_main.c: DeliverDeviceKeyEvents(3248) > Deliver KeyPress as shared grab. value=1997, window=0x1800002
05-25 17:05:17.101+0900 W/STARTER ( 2650): hw_key.c: _key_press_cb(1443) > [_key_press_cb:1443] POWER Key is pressed
05-25 17:05:17.101+0900 W/STARTER ( 2650): hw_key.c: _key_press_cb(1446) > [_key_press_cb:1446] LCD state : 1
05-25 17:05:17.101+0900 E/EFL     ( 2724): ecore_x<2724> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=3962441
05-25 17:05:17.101+0900 W/STARTER ( 2650): hw_key.c: _key_press_cb(1453) > [_key_press_cb:1453] PM state : 1
05-25 17:05:17.101+0900 W/W_HOME  ( 2724): main.c: _direct_home_key_cb(1447) > was_win_on_top:1
05-25 17:05:17.101+0900 E/STARTER ( 2650): hw_key.c: _key_press_cb(1459) > [_key_press_cb:1459] Failed to get VCONFKEY_SIMPLECLOCK_UI_STATUS
05-25 17:05:17.101+0900 W/STARTER ( 2650): hw_key.c: _key_press_cb(1462) > [_key_press_cb:1462] Simple Clock state : 0
05-25 17:05:17.101+0900 W/STARTER ( 2650): hw_key.c: _key_press_cb(1467) > [_key_press_cb:1467] powerkey count : 1
05-25 17:05:17.191+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:05:17.291+0900 W/KEYROUTER( 2318): e_mod_main.c: DeliverDeviceKeyEvents(3275) > Deliver KeyRelease. value=1997, window=0x1800002
05-25 17:05:17.291+0900 W/KEYROUTER( 2318): e_mod_main.c: DeliverDeviceKeyEvents(3275) > Deliver KeyRelease. value=1997, window=0x1e00003
05-25 17:05:17.291+0900 W/STARTER ( 2650): hw_key.c: _key_release_cb(1340) > [_key_release_cb:1340] POWER Key is released
05-25 17:05:17.291+0900 E/EFL     ( 2724): ecore_x<2724> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=3962628
05-25 17:05:17.391+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:05:17.541+0900 W/STARTER ( 2650): hw_key.c: _powerkey_timer_cb(922) > [_powerkey_timer_cb:922] _powerkey_timer_cb, powerkey count[1]
05-25 17:05:17.541+0900 W/STARTER ( 2650): hw_key.c: _powerkey_timer_cb(1132) > [_powerkey_timer_cb:1132] clock visibility[1] pressed lcd status[1], current lcd status[1] pressed pm state[1]
05-25 17:05:17.541+0900 E/STARTER ( 2650): dbus-util.c: dbus_request_cpu_boost(292) > [dbus_request_cpu_boost:292] failed to _invoke_dbus_method_sync
05-25 17:05:17.541+0900 W/AUL     ( 2650): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-home)
05-25 17:05:17.541+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 0
05-25 17:05:17.551+0900 W/AUL_AMD ( 2490): amd_launch.c: _start_app(1782) > caller pid : 2650
05-25 17:05:17.551+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_resume_request_signal(567) > aul_send_app_resume_request_signal app(com.samsung.w-home) pid(2724) type(uiapp) bg(0)
05-25 17:05:17.551+0900 W/AUL_AMD ( 2490): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 2724
05-25 17:05:17.551+0900 W/AUL_AMD ( 2490): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(2724), cmd(0)
05-25 17:05:17.551+0900 I/APP_CORE( 2724): appcore-efl.c: __do_app(453) > [APP 2724] Event: RESET State: RUNNING
05-25 17:05:17.551+0900 I/CAPI_APPFW_APPLICATION( 2724): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-25 17:05:17.551+0900 W/CAPI_APPFW_APP_CONTROL( 2724): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
05-25 17:05:17.551+0900 W/AUL     ( 2650): launch.c: app_request_to_launchpad(298) > request cmd(0) result(2724)
05-25 17:05:17.551+0900 W/W_HOME  ( 2724): main.c: _app_control_progress(1571) > Service value : powerkey
05-25 17:05:17.551+0900 W/wnotib  ( 2724): w-notification-board-broker-main.c: _wnotib_view_event_handler(1308) > Home view event: 0x40001
05-25 17:05:17.551+0900 E/wnotib  ( 2724): w-notification-board-action.c: wnb_action_is_popup_shown(4738) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-25 17:05:17.551+0900 E/wnotib  ( 2724): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-25 17:05:17.551+0900 E/AUL     ( 2650): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
05-25 17:05:17.551+0900 W/wnotib  ( 2724): w-notification-board-broker-main.c: wnotib_main_dismiss_confirmation_popup(1427) > 
05-25 17:05:17.551+0900 W/W_HOME  ( 2724): noti_broker.c: _noti_broker_home_cb(779) > continue the home key execution
05-25 17:05:17.551+0900 E/W_HOME  ( 2724): cs_broker.c: _cs_broker_home_cb(274) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
05-25 17:05:17.551+0900 W/W_HOME  ( 2724): main.c: _home_key_cb(1469) > Home Key operation tutorial:0 window:1 clock:1 apps:0 is_app_resumed:1
05-25 17:05:17.561+0900 W/W_HOME  ( 2724): move.c: move_move_to_apps(216) > move to apps
05-25 17:05:17.561+0900 W/W_HOME  ( 2724): rotary.c: rotary_attach(138) > rotary_attach:0xf808f958
05-25 17:05:17.561+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf808f958, elm_layout, _activated_obj : 0xf7e6e620, activated : 1
05-25 17:05:17.561+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-25 17:05:17.561+0900 W/W_HOME  ( 2724): event_manager.c: _move_module_anim_start_cb(673) > state: 0 -> 1
05-25 17:05:17.561+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:05:17.561+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:05:17.561+0900 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
05-25 17:05:17.561+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
05-25 17:05:17.561+0900 W/STARTER ( 2650): pkg-monitor.c: _app_mgr_status_cb(415) > [_app_mgr_status_cb:415] Resume request [2724]
05-25 17:05:17.561+0900 W/APPS    ( 2724): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
05-25 17:05:17.561+0900 E/AUL     ( 2490): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
05-25 17:05:17.571+0900 I/APP_CORE( 2724): appcore-efl.c: __do_app(529) > Legacy lifecycle: 1
05-25 17:05:17.571+0900 W/W_HOME  ( 2724): event_manager.c: _apptray_visibility_cb(611) > apps,show,start
05-25 17:05:17.571+0900 W/W_HOME  ( 2724): event_manager.c: _apptray_visibility_cb(631) > state: 1 -> 0
05-25 17:05:17.571+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:05:17.571+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:05:17.571+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:05:17.571+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:05:17.571+0900 W/W_HOME  ( 2724): clock_manager.c: _compositing_set(205) > hwc:0
05-25 17:05:17.571+0900 W/W_HOME  ( 2724): noti_broker.c: _apptray_visibility_cb(786) > apps,show,start
05-25 17:05:17.571+0900 W/W_HOME  ( 2724): noti_broker.c: noti_broker_event_fire_to_plugin(1003) > source:1 event:80002
05-25 17:05:17.571+0900 W/wnotib  ( 2724): w-notification-board-broker-main.c: _wnotib_view_event_handler(1308) > Home view event: 0x80002
05-25 17:05:17.571+0900 I/wnotib  ( 2724): w-notification-board-broker-main.c: _wnotib_view_event_handler(1418) > Unhandled type: 0x80002
05-25 17:05:17.581+0900 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
05-25 17:05:17.581+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
05-25 17:05:17.591+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:05:17.661+0900 W/W_HOME  ( 2724): clock_manager.c: _hwc_disabled_timer_cb(125) > hwc disabled
05-25 17:05:17.661+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_unset_buffer(1602) > [3963.008904] layer(0x874f48) now usable
05-25 17:05:17.661+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [3963.008922] layer[0x8749e8]zpos[0]
05-25 17:05:17.781+0900 W/SHealthChartViewer( 9853): ChartViewerApplication.cpp: OnToastPopupPoped(93) > [1;35m ###[0;m
05-25 17:05:17.781+0900 W/SHealthChartViewer( 9853): ChartViewerApplication.cpp: DestoryAppProcess(277) > [1;35m ###[0;m
05-25 17:05:17.791+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:05:17.841+0900 W/W_HOME  ( 2724): event_manager.c: _move_module_anim_end_cb(687) > state: 1 -> 0
05-25 17:05:17.841+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:05:17.841+0900 W/W_HOME  ( 2724): rotary.c: rotary_deattach(156) > rotary_deattach:0xf808f958
05-25 17:05:17.841+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-25 17:05:17.841+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xf808f958, elm_layout, func : 0xf75344fd
05-25 17:05:17.841+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-25 17:05:17.841+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-25 17:05:17.841+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-25 17:05:17.841+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf7e6e620, elm_box, _activated_obj : 0xf808f958, activated : 1
05-25 17:05:17.841+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-25 17:05:17.841+0900 E/wnotib  ( 2724): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-25 17:05:17.841+0900 I/wnotib  ( 2724): w-notification-board-basic-panel.c: _wnb_basic_panel_passed_key_event_allow(6237) > Return true for 4, 101.
05-25 17:05:17.841+0900 I/wnotib  ( 2724): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1225) > No second depth view available.
05-25 17:05:17.841+0900 W/W_HOME  ( 2724): event_manager.c: _apptray_visibility_cb(611) > apps,show
05-25 17:05:17.841+0900 W/W_HOME  ( 2724): event_manager.c: _apptray_visibility_cb(631) > state: 1 -> 1
05-25 17:05:17.841+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-25 17:05:17.841+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-25 17:05:17.841+0900 W/W_HOME  ( 2724): main.c: home_pause(547) > clock/widget paused
05-25 17:05:17.841+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-25 17:05:17.841+0900 W/APPS    ( 2724): apps_main.c: _time_changed_cb(308) >  date : 25->25
05-25 17:05:17.841+0900 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
05-25 17:05:17.841+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
05-25 17:05:17.841+0900 W/APPS    ( 2724): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
05-25 17:05:17.841+0900 W/W_HOME  ( 2724): rotary.c: rotary_attach(138) > rotary_attach:0xf7f28ac0
05-25 17:05:17.841+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf7f28ac0, elm_layout, _activated_obj : 0xf7e6e620, activated : 1
05-25 17:05:17.841+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-25 17:05:17.841+0900 W/W_HOME  ( 2724): win.c: win_back_gesture_disable_set(170) > disable back gesture
05-25 17:05:17.841+0900 W/W_HOME  ( 2724): win.c: win_back_gesture_disable_set(170) > disable back gesture
05-25 17:05:17.841+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-25 17:05:17.841+0900 W/W_HOME  ( 2724): noti_broker.c: _apptray_visibility_cb(786) > apps,show
05-25 17:05:17.841+0900 W/W_HOME  ( 2724): noti_broker.c: noti_broker_event_fire_to_plugin(1003) > source:1 event:80000
05-25 17:05:17.841+0900 W/wnotib  ( 2724): w-notification-board-broker-main.c: _wnotib_view_event_handler(1308) > Home view event: 0x80000
05-25 17:05:17.841+0900 E/wnotib  ( 2724): w-notification-board-action.c: wnb_action_is_event_receivable(5108) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-25 17:05:17.841+0900 I/wnotib  ( 2724): w-notification-board-basic-panel.c: _wnb_basic_panel_close_second_depth_view(6316) > wnotib_action_drawer_is_event_receivable: 0, third_depth_genlist: (nil), _wnotib_basic_panel_is_third_depth_thread_view: 0, wnotib_common_is_toast_popup_displayed: 0
05-25 17:05:17.841+0900 E/wnotib  ( 2724): w-notification-board-action.c: wnb_action_is_event_receivable(5108) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-25 17:05:17.841+0900 I/wnotib  ( 2724): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed_cb(1030) > is_app_tray_displayed: 1
05-25 17:05:17.841+0900 W/wnotib  ( 2724): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [3], notiboard card appending count [8].
05-25 17:05:17.841+0900 E/APPS    ( 2724): apps_main.c: apps_main_resume(1003) >  resumed already
05-25 17:05:17.861+0900 W/WATCH_CORE( 2779): appcore-watch.c: __widget_pause(1113) > widget_pause
05-25 17:05:17.871+0900 W/AUL     ( 2779): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.chronograph16) pid(2779) status(bg) type(watchapp)
05-25 17:05:17.871+0900 D/chronograph( 2779): ChronographApp.cpp: _appPause(150) > [0;34m>>>HIT<<<[0;m
05-25 17:05:17.871+0900 W/chronograph( 2779): ChronographViewController.cpp: onPause(183) > [0;35mState is Pause[isPaused=1], StopwatchState=0[0;m
05-25 17:05:17.871+0900 W/chronograph( 2779): ChronographSweepSecond.cpp: resetSweepSecond(103) > [0;35mresetSweepSecond >>>>[0;m
05-25 17:05:17.871+0900 D/chronograph( 2779): ChronographSweepSecond.cpp: resetSweepSecond(107) > Stop and Clear sweepAnimation !!
05-25 17:05:17.871+0900 D/chronograph-common( 2779): ChronographSensor.cpp: disableAcceleormeter(52) > [0;32mBEGIN >>>>[0;m
05-25 17:05:17.871+0900 D/chronograph-common( 2779): ChronographSensor.cpp: _stopAccelerometer(129) > [0;32mBEGIN >>>>[0;m
05-25 17:05:18.561+0900 W/AUL_AMD ( 2490): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-25 17:05:18.561+0900 W/AUL_AMD ( 2490): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
05-25 17:05:18.841+0900 E/EFL     ( 2724): ecore_x<2724> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=3964187 button=1
05-25 17:05:18.841+0900 W/APPS    ( 2724): AppsViewNecklace.cpp: touchPressed(1639) >  TOUCH [84, 291]
05-25 17:05:18.951+0900 E/EFL     ( 2724): ecore_x<2724> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=3964295 button=1
05-25 17:05:18.951+0900 W/APPS    ( 2724): AppsViewNecklace.cpp: touchReleased(1952) >  TOUCH [84, 291]->[88, 292]
05-25 17:05:18.951+0900 W/APPS    ( 2724): AppsViewNecklace.cpp: runFocusAni(3467) >  nNewFocus[21], anim[1], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[23]
05-25 17:05:18.951+0900 W/APPS    ( 2724): AppsItem.cpp: onItemClicked(463) >  onItemClicked[0,21]
05-25 17:05:18.951+0900 E/APPS    ( 2724): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
05-25 17:05:18.951+0900 W/APPS    ( 2724): AppsItem.cpp: onItemClicked(487) >  item(clover) launched, open(0), tts(0)
05-25 17:05:18.951+0900 W/AUL     ( 2724): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.clover)
05-25 17:05:18.951+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 0
05-25 17:05:18.951+0900 W/AUL_AMD ( 2490): amd_launch.c: _start_app(1782) > caller pid : 2724
05-25 17:05:18.951+0900 I/AUL_AMD ( 2490): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
05-25 17:05:18.971+0900 E/RESOURCED( 2613): block.c: block_prelaunch_state(138) > insert data org.example.clover, table num : 3
05-25 17:05:18.971+0900 W/AUL_AMD ( 2490): amd_launch.c: _start_app(2218) > pad pid(-5)
05-25 17:05:18.971+0900 W/AUL_PAD ( 3264): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
05-25 17:05:18.971+0900 W/AUL_PAD ( 3264): launchpad.c: __send_result_to_caller(272) > Check app launching
05-25 17:05:18.971+0900 W/AUL_PAD ( 9986): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
05-25 17:05:18.971+0900 W/AUL_PAD ( 9986): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
05-25 17:05:18.971+0900 W/AUL_PAD ( 9986): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
05-25 17:05:18.971+0900 W/AUL_PAD ( 9986): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.clover)
05-25 17:05:18.981+0900 I/APP_CORE( 9853): appcore-efl.c: __do_app(453) > [APP 9853] Event: MEM_FLUSH State: PAUSED
05-25 17:05:19.021+0900 I/efl-extension( 9986): efl_extension.c: eext_mod_init(40) > Init
05-25 17:05:19.021+0900 W/AUL_PAD ( 9986): launchpad_loader.c: main(690) > [candidate] dlsym
05-25 17:05:19.021+0900 W/AUL_PAD ( 9986): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.clover)
05-25 17:05:19.021+0900 I/CAPI_APPFW_APPLICATION( 9986): app_main.c: ui_app_main(704) > app_efl_main
05-25 17:05:19.021+0900 I/CAPI_APPFW_APPLICATION( 9986): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-25 17:05:19.071+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.clover) pid(9986) type(uiapp) bg(0)
05-25 17:05:19.071+0900 W/AUL     ( 2724): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9986)
05-25 17:05:19.071+0900 W/W_HOME  ( 2724): util.c: apps_util_launch_main_operation(643) > Launch app:[clover] ret:[0]
05-25 17:05:19.081+0900 W/STARTER ( 2650): pkg-monitor.c: _app_mgr_status_cb(394) > [_app_mgr_status_cb:394] Launch request [9986]
05-25 17:05:19.091+0900 W/AUL_AMD ( 2490): amd_status.c: __socket_monitor_cb(1277) > (9986) was created
05-25 17:05:19.091+0900 E/AUL     ( 2490): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
05-25 17:05:19.131+0900 E/EFL     ( 9986): ecore_evas<9986> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-25 17:05:19.141+0900 W/W_HOME  ( 2724): event_manager.c: _ecore_x_message_cb(428) > state: 0 -> 1
05-25 17:05:19.141+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-25 17:05:19.141+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-25 17:05:19.141+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-25 17:05:19.141+0900 W/W_HOME  ( 2724): win.c: win_back_gesture_disable_set(173) > enable back gesture
05-25 17:05:19.141+0900 W/W_HOME  ( 2724): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 0
05-25 17:05:19.141+0900 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
05-25 17:05:19.141+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
05-25 17:05:19.211+0900 E/EFL     ( 9986): elementary<9986> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
05-25 17:05:19.231+0900 E/EFL     ( 9986): elementary<9986> elc_naviframe.c:2950 elm_naviframe_item_push() item(0xf7be99a8) will be pushed
05-25 17:05:19.261+0900 E/TIZEN_N_RECORDER( 9986): recorder.c: __convert_recorder_error_code(193) > [audio-channel] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:05:19.261+0900 E/TIZEN_N_RECORDER( 9986): recorder.c: __convert_recorder_error_code(193) > [audio-device] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:05:19.261+0900 I/APP_CORE( 9986): appcore-efl.c: __do_app(453) > [APP 9986] Event: RESET State: CREATED
05-25 17:05:19.261+0900 I/CAPI_APPFW_APPLICATION( 9986): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-25 17:05:19.271+0900 I/APP_CORE( 9986): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
05-25 17:05:19.271+0900 I/APP_CORE( 9986): appcore-efl.c: __do_app(524) > [APP 9986] Initial Launching, call the resume_cb
05-25 17:05:19.271+0900 I/CAPI_APPFW_APPLICATION( 9986): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-25 17:05:19.271+0900 W/APP_CORE( 9986): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3600002
05-25 17:05:19.321+0900 W/W_HOME  ( 2724): event_manager.c: _window_visibility_cb(473) > Window [0x1E00003] is now visible(1)
05-25 17:05:19.321+0900 W/W_HOME  ( 2724): event_manager.c: _window_visibility_cb(483) > state: 1 -> 0
05-25 17:05:19.321+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-25 17:05:19.321+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-25 17:05:19.321+0900 W/W_HOME  ( 2724): main.c: _window_visibility_cb(964) > Window [0x1E00003] is now visible(1)
05-25 17:05:19.321+0900 I/APP_CORE( 9986): appcore-efl.c: __do_app(453) > [APP 9986] Event: RESUME State: RUNNING
05-25 17:05:19.321+0900 I/APP_CORE( 2724): appcore-efl.c: __do_app(453) > [APP 2724] Event: PAUSE State: RUNNING
05-25 17:05:19.321+0900 I/CAPI_APPFW_APPLICATION( 2724): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-25 17:05:19.321+0900 W/W_HOME  ( 2724): main.c: _appcore_pause_cb(488) > appcore pause
05-25 17:05:19.321+0900 W/W_HOME  ( 2724): event_manager.c: _app_pause_cb(397) > state: 1 -> 2
05-25 17:05:19.321+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-25 17:05:19.331+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2724) status(bg) type(uiapp)
05-25 17:05:19.331+0900 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2724] goes to (4)
05-25 17:05:19.331+0900 E/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2724)'s state(4)
05-25 17:05:19.331+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-25 17:05:19.331+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-25 17:05:19.331+0900 W/W_HOME  ( 2724): rotary.c: rotary_deattach(156) > rotary_deattach:0xf7f28ac0
05-25 17:05:19.331+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-25 17:05:19.331+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xf7f28ac0, elm_layout, func : 0xf75344fd
05-25 17:05:19.331+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-25 17:05:19.331+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-25 17:05:19.331+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-25 17:05:19.331+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf7e6e620, elm_box, _activated_obj : 0xf7f28ac0, activated : 1
05-25 17:05:19.331+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-25 17:05:19.331+0900 E/wnotib  ( 2724): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-25 17:05:19.331+0900 I/wnotib  ( 2724): w-notification-board-basic-panel.c: _wnb_basic_panel_passed_key_event_allow(6237) > Return true for 4, 101.
05-25 17:05:19.331+0900 I/wnotib  ( 2724): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1225) > No second depth view available.
05-25 17:05:19.331+0900 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
05-25 17:05:19.331+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
05-25 17:05:19.341+0900 W/APPS    ( 2724): AppsItem.cpp: setLastIndex(1264) >  This is last index app [22:WDS_AT_OPT_GET_MORE_APPS_ABB], focusIdx[21]
05-25 17:05:19.341+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.clover) pid(9986) status(fg) type(uiapp)
05-25 17:05:19.341+0900 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[9986] goes to (3)
05-25 17:05:19.341+0900 W/APPS    ( 2724): AppsViewNecklace.cpp: __onSignalHideNextPage(7029) >  Hide next page [0->0]
05-25 17:05:19.351+0900 W/APPS    ( 2724): AppsItem.cpp: aniFocusIndex(2351) >  [clover:21] Focused[1], focusIdx[21]
05-25 17:05:19.351+0900 W/W_HOME  ( 2724): win.c: win_back_gesture_disable_set(173) > enable back gesture
05-25 17:05:19.351+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-25 17:05:19.351+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-25 17:05:19.351+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-25 17:05:19.351+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-25 17:05:19.351+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-25 17:05:19.351+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-25 17:05:19.351+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-25 17:05:19.351+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:05:19.351+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-25 17:05:19.351+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-25 17:05:19.351+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-25 17:05:19.351+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-25 17:05:19.351+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
05-25 17:05:19.351+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-25 17:05:19.351+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-25 17:05:19.351+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-25 17:05:19.351+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-25 17:05:19.351+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:05:19.351+0900 E/CAPI_APPFW_APP_CONTROL( 2895): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-25 17:05:19.351+0900 W/MUSIC_CONTROL_SERVICE( 2895): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:2895]   [com.samsung.w-home]register msg port [false][0m
05-25 17:05:19.361+0900 I/wnotib  ( 2724): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
05-25 17:05:19.361+0900 E/wnotib  ( 2724): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-25 17:05:19.361+0900 W/wnotib  ( 2724): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [3], notiboard card appending count [8].
05-25 17:05:19.381+0900 W/APPS    ( 2724): AppsViewNecklace.cpp: onPausedIdlerCb(5156) >  elm_cache_all_flush
05-25 17:05:19.731+0900 E/AUL     ( 2490): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
05-25 17:05:19.871+0900 I/APP_CORE( 2724): appcore-efl.c: __do_app(453) > [APP 2724] Event: MEM_FLUSH State: PAUSED
05-25 17:05:20.181+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 14
05-25 17:05:20.201+0900 W/AUL_AMD ( 2490): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9986
05-25 17:05:20.201+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 12
05-25 17:05:20.211+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 14
05-25 17:05:20.231+0900 W/AUL_AMD ( 2490): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9986
05-25 17:05:20.231+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 12
05-25 17:05:20.411+0900 I/AUL_PAD ( 9997): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
05-25 17:05:22.281+0900 E/EFL     ( 9986): ecore_x<9986> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=3967628 button=1
05-25 17:05:22.301+0900 E/WMS     ( 2450): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23510) > _wms_event_handler_cb_nomove_detector is called
05-25 17:05:22.391+0900 E/EFL     ( 9986): ecore_x<9986> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=3967736 button=1
05-25 17:05:22.471+0900 I/USR_TAG ( 9986): record_start
05-25 17:05:22.471+0900 E/TIZEN_N_RECORDER( 9986): recorder.c: __convert_recorder_error_code(193) > [recorder_attr_set_time_limit] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:05:22.471+0900 E/TIZEN_N_RECORDER( 9986): recorder.c: __convert_recorder_error_code(193) > [recorder_set_filename] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:05:22.471+0900 E/TIZEN_N_RECORDER( 9986): recorder.c: __convert_recorder_error_code(193) > [file-format] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:05:22.471+0900 E/TIZEN_N_RECORDER( 9986): recorder.c: __convert_recorder_error_code(193) > [audio-encoder] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:05:22.791+0900 E/TIZEN_N_RECORDER( 9986): recorder.c: __convert_recorder_error_code(193) > [recorder_start] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:05:22.791+0900 E/EFL     ( 9986): <9986> elm_main.c:1300 elm_object_disabled_set() safety check failed: obj == NULL
05-25 17:05:22.791+0900 E/EFL     ( 9986): <9986> elm_main.c:1300 elm_object_disabled_set() safety check failed: obj == NULL
05-25 17:05:22.801+0900 E/EFL     ( 9986): elementary<9986> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
05-25 17:05:22.821+0900 E/EFL     ( 9986): elementary<9986> elc_naviframe.c:2950 elm_naviframe_item_push() item(0xf2c197a0) will be pushed
05-25 17:05:22.831+0900 E/EFL     ( 9986): elementary<9986> elc_naviframe.c:2796 _push_transition_cb() item(0xf2c197a0) will transition
05-25 17:05:23.261+0900 E/EFL     ( 9986): elementary<9986> elc_naviframe.c:1193 _on_item_push_finished() item(0xf7be99a8) transition finished
05-25 17:05:23.261+0900 E/EFL     ( 9986): elementary<9986> elc_naviframe.c:1218 _on_item_show_finished() item(0xf2c197a0) transition finished
05-25 17:05:23.401+0900 E/EFL     ( 2318): ecore_x<2318> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x3600002 time=3968168
05-25 17:05:23.401+0900 E/EFL     ( 9986): ecore_x<9986> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=3968168
05-25 17:05:23.411+0900 E/EFL     ( 2318): ecore_x<2318> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=3968168
05-25 17:05:24.361+0900 I/APP_CORE( 2724): appcore-efl.c: __do_app(453) > [APP 2724] Event: MEM_FLUSH State: PAUSED
05-25 17:05:25.001+0900 E/WMS     ( 2450): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23510) > _wms_event_handler_cb_nomove_detector is called
05-25 17:05:25.191+0900 I/USR_TAG ( 9986): loud sound is detected!
05-25 17:05:25.541+0900 W/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
05-25 17:05:25.541+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
05-25 17:05:25.541+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:05:25.541+0900 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2724] goes to (3)
05-25 17:05:25.541+0900 E/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2724)'s state(3)
05-25 17:05:25.551+0900 W/AUL_AMD ( 2490): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-25 17:05:25.551+0900 W/AUL_AMD ( 2490): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
05-25 17:05:25.551+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2724) status(fg) type(uiapp)
05-25 17:05:25.551+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 9986 pgid = 9986
05-25 17:05:25.551+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
05-25 17:05:25.651+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
05-25 17:05:25.661+0900 I/AUL_AMD ( 2490): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 9986
05-25 17:05:25.661+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(9986)
05-25 17:05:25.711+0900 W/PROCESSMGR( 2318): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
05-25 17:05:25.721+0900 W/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
05-25 17:05:25.721+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
05-25 17:05:25.721+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:05:25.721+0900 W/CRASH_MANAGER(10013): worker.c: worker_job(1199) > 1109986636c6f149569952

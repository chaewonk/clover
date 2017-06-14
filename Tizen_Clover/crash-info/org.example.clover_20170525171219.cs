S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.1
Build-Number: R760XXU1APL2
Build-Date: 2016.12.20 22:57:01

Crash Information
Process Name: clover
PID: 10958
Date: 2017-05-25 17:12:19+0900
Executable File Path: /opt/usr/apps/org.example.clover/bin/clover
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 10958, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0xf5ac625c, r3   = 0x00000001
r4   = 0xf2108438, r5   = 0xf7881880
r6   = 0xf78818c8, r7   = 0xff9aed40
r8   = 0x00000041, r9   = 0xf6e06824
r10  = 0xf77cd208, fp   = 0x00000000
ip   = 0xf5ac629c, sp   = 0xff9aecd0
lr   = 0xf6c525d0, pc   = 0xf5ab3182
cpsr = 0x60000030

Memory Information
MemTotal:   714608 KB
MemFree:     20204 KB
Buffers:     31764 KB
Cached:     167916 KB
VmPeak:     188068 KB
VmSize:     143944 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       35516 KB
VmRSS:       32892 KB
VmData:      74104 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       29384 KB
VmPTE:         168 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 10958 TID = 10958
10958 11038 11039 11046 

Maps Information
f0b88000 f0b8b000 r-xp /usr/lib/gstreamer-0.10/libgstwavenc.so
f0b93000 f0bad000 r-xp /usr/lib/gstreamer-0.10/libgstpulse.so
f0bb6000 f0bee000 r-xp /usr/lib/libsamrnb.so
f0c11000 f0c1c000 r-xp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
f0c25000 f0c35000 r-xp /usr/lib/gstreamer-0.10/libgstalsa.so
f0c3d000 f0c43000 r-xp /usr/lib/libscmn.so
f0c4b000 f0c83000 r-xp /usr/lib/libsaac.so
f0c8d000 f0c92000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencamrnb.so
f0c9a000 f0caa000 r-xp /usr/lib/lib_SamsungRec_TizenV04015.so
f0ccb000 f0cd3000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
f0ce2000 f0ce7000 r-xp /usr/lib/gstreamer-0.10/libgstsecrecord.so
f0cf9000 f0d11000 r-xp /usr/lib/libgstcontroller-0.10.so.0.30.0
f0d21000 f0d27000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencaac.so
f0d2f000 f0d47000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
f0d50000 f0d79000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
f0d8b000 f0d90000 r-xp /usr/lib/gstreamer-0.10/libgstvolume.so
f0d98000 f0ef6000 r-xp /usr/lib/gstreamer-0.10/libgstffmpeg.so
f0fde000 f0fea000 r-xp /usr/lib/gstreamer-0.10/libgstencodebin.so
f0ff2000 f1012000 r-xp /usr/lib/gstreamer-0.10/libgstomx.so
f1013000 f1047000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
f1050000 f105b000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
f1063000 f1065000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
f106d000 f106e000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
f1076000 f107e000 r-xp /usr/lib/libfeedback.so.0.1.4
f1101000 f1900000 rw-p [stack:11039]
f1901000 f2100000 rw-p [stack:11038]
f2204000 f2207000 r-xp /usr/lib/gstreamer-0.10/libgstavsysaudiosrc.so
f220f000 f2210000 r-xp /usr/lib/gstreamer-0.10/libgstapp.so
f2218000 f2219000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
f22c9000 f2ac8000 rw-p [stack:11046]
f2ac8000 f2ac9000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
f340b000 f340d000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
f3415000 f342c000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f3439000 f343e000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f3446000 f3451000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f378b000 f387d000 r-xp /usr/lib/libCOREGL.so.4.0
f3896000 f389b000 r-xp /usr/lib/libsystem.so.0.0.0
f38a5000 f38a6000 r-xp /usr/lib/libresponse.so.0.2.96
f38ae000 f38b3000 r-xp /usr/lib/libproc-stat.so.0.2.96
f38bc000 f38be000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f38c6000 f38cd000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f38d6000 f38f8000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f3901000 f3905000 r-xp /usr/lib/libogg.so.0.7.1
f390d000 f392f000 r-xp /usr/lib/libvorbis.so.0.4.3
f3937000 f393a000 r-xp /usr/lib/libtinycompress.so.0.0.0
f3942000 f3951000 r-xp /usr/lib/libmdm-common.so.1.1.22
f395a000 f3962000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f396a000 f3970000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f3979000 f3980000 r-xp /usr/lib/libminizip.so.1.0.0
f3988000 f398a000 r-xp /usr/lib/libttrace.so.1.1
f3992000 f39d9000 r-xp /usr/lib/libsndfile.so.1.0.26
f39e5000 f3a2e000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f3a37000 f3a3c000 r-xp /usr/lib/libjson.so.0.0.1
f52d5000 f53db000 r-xp /usr/lib/libicuuc.so.57.1
f53f1000 f5579000 r-xp /usr/lib/libicui18n.so.57.1
f5589000 f5596000 r-xp /usr/lib/libail.so.0.1.0
f559f000 f55a2000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f55aa000 f55ad000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f55b5000 f5616000 r-xp /usr/lib/libasound.so.2.0.0
f5620000 f5636000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f563e000 f5642000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f564a000 f568b000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
f5694000 f5696000 r-xp /usr/lib/libdri2.so.0.0.0
f569e000 f56a6000 r-xp /usr/lib/libdrm.so.2.4.0
f56ae000 f56b4000 r-xp /usr/lib/libxcb-render.so.0.0.0
f56bc000 f56bd000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f56c6000 f56ca000 r-xp /usr/lib/libEGL.so.1.4
f56da000 f56eb000 r-xp /usr/lib/libGLESv2.so.2.0
f56fb000 f5743000 r-xp /usr/lib/libmdm.so.1.2.62
f5744000 f574b000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f5753000 f575e000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f576b000 f5784000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f578c000 f5791000 r-xp /usr/lib/libstorage.so.0.1
f5799000 f579e000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f57a6000 f57de000 r-xp /usr/lib/libpulse.so.0.16.2
f57df000 f57e3000 r-xp /usr/lib/libmmfsession.so.0.0.0
f57ec000 f5803000 r-xp /usr/lib/libmmfsound.so.0.1.0
f5815000 f5836000 r-xp /usr/lib/libexif.so.12.3.3
f5849000 f5852000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
f585a000 f5867000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
f5870000 f587b000 r-xp /usr/lib/libtbm.so.1.0.0
f5883000 f5888000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f5890000 f5948000 r-xp /usr/lib/libcairo.so.2.11200.14
f5953000 f59ee000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
f59fa000 f5a4a000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
f5a50000 f5a62000 r-xp /usr/lib/libcapi-media-camera.so.0.1.35
f5a6a000 f5a8b000 r-xp /usr/lib/libefl-extension.so.0.1.0
f5a93000 f5a98000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5aa0000 f5aa8000 r-xp /usr/lib/libcapi-media-recorder.so.0.1.28
f5ab0000 f5ab7000 r-xp /opt/usr/apps/org.example.clover/bin/clover
f5c59000 f5c63000 r-xp /lib/libnss_files-2.13.so
f5c6c000 f5d3b000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f5d51000 f5d75000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f5d7e000 f5d84000 r-xp /usr/lib/libappsvc.so.0.1.0
f5d8c000 f5d8e000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f5d97000 f5d9b000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f5da7000 f5db2000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f5dba000 f5dbc000 r-xp /usr/lib/libiniparser.so.0
f5dc5000 f5dca000 r-xp /usr/lib/libappcore-common.so.1.1
f5dd2000 f5dd4000 r-xp /usr/lib/libcamsrcjpegenc.so.0.0.0
f5ddc000 f5de0000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f5ded000 f5def000 r-xp /usr/lib/libXau.so.6.0.0
f5df7000 f5dfe000 r-xp /lib/libcrypt-2.13.so
f5e2e000 f5e30000 r-xp /usr/lib/libiri.so
f5e39000 f5fe2000 r-xp /usr/lib/libcrypto.so.1.0.0
f6002000 f6049000 r-xp /usr/lib/libssl.so.1.0.0
f6055000 f6083000 r-xp /usr/lib/libidn.so.11.5.44
f608b000 f6094000 r-xp /usr/lib/libcares.so.2.1.0
f609e000 f60b1000 r-xp /usr/lib/libxcb.so.1.1.0
f60ba000 f60bc000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f60c4000 f60c6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f60cf000 f619b000 r-xp /usr/lib/libxml2.so.2.7.8
f61a8000 f61aa000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f61b3000 f61b8000 r-xp /usr/lib/libffi.so.5.0.10
f61c0000 f61c1000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f61c9000 f61cc000 r-xp /lib/libattr.so.1.1.0
f61d4000 f6268000 r-xp /usr/lib/libstdc++.so.6.0.16
f627b000 f6298000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f62a2000 f62ba000 r-xp /usr/lib/libpng12.so.0.50.0
f62c2000 f62d8000 r-xp /lib/libexpat.so.1.6.0
f62e2000 f6326000 r-xp /usr/lib/libcurl.so.4.3.0
f632f000 f6339000 r-xp /usr/lib/libXext.so.6.4.0
f6342000 f6346000 r-xp /usr/lib/libXtst.so.6.1.0
f634e000 f6354000 r-xp /usr/lib/libXrender.so.1.3.0
f635c000 f6362000 r-xp /usr/lib/libXrandr.so.2.2.0
f636a000 f636b000 r-xp /usr/lib/libXinerama.so.1.0.0
f6374000 f637d000 r-xp /usr/lib/libXi.so.6.1.0
f6385000 f6388000 r-xp /usr/lib/libXfixes.so.3.1.0
f6390000 f6392000 r-xp /usr/lib/libXgesture.so.7.0.0
f639a000 f639c000 r-xp /usr/lib/libXcomposite.so.1.0.0
f63a4000 f63a6000 r-xp /usr/lib/libXdamage.so.1.1.0
f63ae000 f63b5000 r-xp /usr/lib/libXcursor.so.1.0.2
f63bd000 f63c0000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f63c8000 f63cc000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f63d5000 f63da000 r-xp /usr/lib/libecore_fb.so.1.7.99
f63e3000 f64c4000 r-xp /usr/lib/libX11.so.6.3.0
f64cf000 f64f2000 r-xp /usr/lib/libjpeg.so.8.0.2
f650a000 f6520000 r-xp /lib/libz.so.1.2.5
f6528000 f652a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6532000 f65a7000 r-xp /usr/lib/libsqlite3.so.0.8.6
f65b1000 f65cb000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f65d3000 f6607000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6610000 f66e3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f66ee000 f66fe000 r-xp /lib/libresolv-2.13.so
f6702000 f671a000 r-xp /usr/lib/liblzma.so.5.0.3
f6722000 f6725000 r-xp /lib/libcap.so.2.21
f672d000 f675c000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6764000 f6765000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f676d000 f6773000 r-xp /usr/lib/libecore_imf.so.1.7.99
f677b000 f6792000 r-xp /usr/lib/liblua-5.1.so
f679b000 f67a2000 r-xp /usr/lib/libembryo.so.1.7.99
f67aa000 f67b0000 r-xp /lib/librt-2.13.so
f67b9000 f680f000 r-xp /usr/lib/libpixman-1.so.0.28.2
f681c000 f6872000 r-xp /usr/lib/libfreetype.so.6.11.3
f687e000 f68a6000 r-xp /usr/lib/libfontconfig.so.1.8.0
f68a7000 f68ec000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f68f5000 f6908000 r-xp /usr/lib/libfribidi.so.0.3.1
f6910000 f692a000 r-xp /usr/lib/libecore_con.so.1.7.99
f6933000 f693c000 r-xp /usr/lib/libedbus.so.1.7.99
f6944000 f6994000 r-xp /usr/lib/libecore_x.so.1.7.99
f6996000 f699f000 r-xp /usr/lib/libvconf.so.0.2.45
f69a7000 f69b8000 r-xp /usr/lib/libecore_input.so.1.7.99
f69c0000 f69c5000 r-xp /usr/lib/libecore_file.so.1.7.99
f69cd000 f69ef000 r-xp /usr/lib/libecore_evas.so.1.7.99
f69f8000 f6a39000 r-xp /usr/lib/libeina.so.1.7.99
f6a42000 f6a5b000 r-xp /usr/lib/libeet.so.1.7.99
f6a6c000 f6ad5000 r-xp /lib/libm-2.13.so
f6ade000 f6ae4000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6aed000 f6aee000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6af6000 f6b19000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b21000 f6b26000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b2e000 f6b58000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b61000 f6b78000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b80000 f6b8b000 r-xp /lib/libunwind.so.8.0.1
f6bb8000 f6bd6000 r-xp /usr/lib/libsystemd.so.0.4.0
f6be0000 f6d04000 r-xp /lib/libc-2.13.so
f6d12000 f6d1a000 r-xp /lib/libgcc_s-4.6.so.1
f6d1b000 f6d1f000 r-xp /usr/lib/libsmack.so.1.0.0
f6d28000 f6d2e000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f6d36000 f6e06000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e07000 f6e65000 r-xp /usr/lib/libedje.so.1.7.99
f6e6f000 f6e86000 r-xp /usr/lib/libecore.so.1.7.99
f6e9d000 f6f6b000 r-xp /usr/lib/libevas.so.1.7.99
f6f90000 f70cc000 r-xp /usr/lib/libelementary.so.1.7.99
f70e3000 f70f7000 r-xp /lib/libpthread-2.13.so
f7102000 f7104000 r-xp /usr/lib/libdlog.so.0.0.0
f710c000 f710f000 r-xp /usr/lib/libbundle.so.0.1.22
f7117000 f7119000 r-xp /lib/libdl-2.13.so
f7122000 f712f000 r-xp /usr/lib/libaul.so.0.1.0
f7140000 f7146000 r-xp /usr/lib/libappcore-efl.so.1.1
f714f000 f7153000 r-xp /usr/lib/libsys-assert.so
f715c000 f7179000 r-xp /lib/ld-2.13.so
f7182000 f7187000 r-xp /usr/bin/launchpad-loader
f76e4000 f7896000 rw-p [heap]
ff990000 ff9b1000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10958)
Call Stack Count: 19
 0: setSoundImage + 0xc1 (0xf5ab3182) [/opt/usr/apps/org.example.clover/bin/clover] + 0x3182
 1: send_audio + 0x2c4 (0xf5ab29a5) [/opt/usr/apps/org.example.clover/bin/clover] + 0x29a5
 2: record_stop + 0xce (0xf5ab26ab) [/opt/usr/apps/org.example.clover/bin/clover] + 0x26ab
 3: _on_recording_limit_reached_cb + 0x20 (0xf5ab335d) [/opt/usr/apps/org.example.clover/bin/clover] + 0x335d
 4: (0xf5aa2eb5) [/usr/lib/libcapi-media-recorder.so.0] + 0x2eb5
 5: _mmcamcroder_msg_callback + 0x52 (0xf5a33d07) [/usr/lib/libmmfcamcorder.so.0] + 0x39d07
 6: (0xf6d69fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
 7: g_main_context_dispatch + 0xbc (0xf6d6b7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
 8: (0xf6e7fca7) [/usr/lib/libecore.so.1] + 0x10ca7
 9: (0xf6e7ab4f) [/usr/lib/libecore.so.1] + 0xbb4f
10: (0xf6e7b5a7) [/usr/lib/libecore.so.1] + 0xc5a7
11: ecore_main_loop_begin + 0x30 (0xf6e7b879) [/usr/lib/libecore.so.1] + 0xc879
12: appcore_efl_main + 0x332 (0xf7143b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
13: ui_app_main + 0xb0 (0xf5dde421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
14: uib_app_run + 0xea (0xf5ab2edb) [/opt/usr/apps/org.example.clover/bin/clover] + 0x2edb
15: main + 0x34 (0xf5ab2489) [/opt/usr/apps/org.example.clover/bin/clover] + 0x2489
16: (0xf7183a53) [/opt/usr/apps/org.example.clover/bin/clover] + 0x1a53
17: __libc_start_main + 0x114 (0xf6bf785c) [/lib/libc.so.6] + 0x1785c
18: (0xf7183e0c) [/opt/usr/apps/org.example.clover/bin/clover] + 0x1e0c
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
7:12:04.821+0900 I/efl-extension(10959): efl_extension.c: eext_mod_init(40) > Init
05-25 17:12:04.891+0900 I/UXT     (10959): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
05-25 17:12:04.961+0900 I/AUL_PAD (10959): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
05-25 17:12:05.001+0900 E/MALI    (10959): mali_egl_winsys.c: window_surface_new(889) >  Create Window, it runs with MALI_X11_ASYNC_PAGEFLIP 1 
05-25 17:12:05.091+0900 E/PKGMGR_OBSERVER(10949): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[109490002] pkg_type[tpk] pkgid[org.example.clover] key[end] val[ok]
05-25 17:12:05.101+0900 W/W_HOME  ( 2724): clock_event.c: _pkgmgr_event_cb(247) > Pkg:org.example.clover is updated, need to check validation
05-25 17:12:05.101+0900 W/W_HOME  ( 2724): clock_event.c: _pkgmgr_event_cb(251) > attacheck clock:com.samsung.chronograph16
05-25 17:12:05.121+0900 W/AUL_AMD ( 2490): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(org.example.clover), key(end), value(ok)
05-25 17:12:05.141+0900 E/WMS     ( 2450): wms_event_handler.c: _wms_event_handler_cb_log_package(4744) > package [_________] callback : [INSTALL, COMPLETED]
05-25 17:12:05.141+0900 E/WMS     ( 2450): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7080) > package install complete
05-25 17:12:05.141+0900 E/WMS     ( 2450): wms_event_handler.c: _wms_event_handler_package_install_event(5034) > 
05-25 17:12:05.141+0900 E/WMS     ( 2450): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(2040) > Found in install_req_list?[0], index[-1]
05-25 17:12:05.141+0900 E/WMS     ( 2450): wms_event_handler.c: _wms_event_handler_package_install_event(5060) > triggered from Gear itself.
05-25 17:12:05.191+0900 E/STARTER ( 2650): pkg-monitor.c: _pkg_monitor_get_metadata(136) > [_pkg_monitor_get_metadata:136] Failed to get metadata value[-2]
05-25 17:12:05.221+0900 E/PKGMGR_INFO(10949): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(1026) > callback is stopped.
05-25 17:12:05.231+0900 E/PKGMGR_INFO( 2447): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(922) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
05-25 17:12:05.231+0900 E/WMS     ( 2450): wms_db.c: wms_db_package_event_insert_record(190) > 
05-25 17:12:05.231+0900 E/PKGMGR_OBSERVER(10949): pkg_observer.c: main(620) > OBSERVER end
05-25 17:12:05.251+0900 E/WMS     ( 2450): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2886) > send_install_response completed : END
05-25 17:12:05.261+0900 E/PKGMGR_SERVER(10894): pkgmgr-server.c: sighandler(486) > child NORMAL exit [10949]
05-25 17:12:05.271+0900 W/APPS    ( 2724): AppsViewNecklace.cpp: onTouchEventCancel(4949) >  touch cancel
05-25 17:12:05.711+0900 I/AUL     (10960): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:12:05.721+0900 I/AUL     (10960): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:12:05.721+0900 E/AUL     (10960): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:12:05.721+0900 E/AUL     (10960): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:12:05.731+0900 I/AUL     (10960): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:12:05.741+0900 I/AUL     (10960): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:12:05.741+0900 E/AUL     (10960): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:12:05.751+0900 E/AUL     (10960): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:12:05.761+0900 I/AUL     (10960): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:12:05.771+0900 I/AUL     (10960): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:12:05.771+0900 E/AUL     (10960): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:12:05.771+0900 E/AUL     (10960): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:12:05.781+0900 I/AUL     (10960): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:12:05.791+0900 I/AUL     (10960): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:12:05.791+0900 E/AUL     (10960): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:12:05.791+0900 E/AUL     (10960): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:12:05.801+0900 I/AUL     (10960): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:12:05.811+0900 I/AUL     (10960): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:12:05.811+0900 E/AUL     (10960): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:12:05.811+0900 E/AUL     (10960): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:12:05.821+0900 I/AUL     (10960): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:12:05.831+0900 I/AUL     (10960): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:12:05.831+0900 E/AUL     (10960): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:12:05.831+0900 E/AUL     (10960): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:12:05.841+0900 I/AUL     (10960): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:12:05.851+0900 I/AUL     (10960): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:12:05.851+0900 E/AUL     (10960): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:12:05.851+0900 E/AUL     (10960): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:12:05.861+0900 I/AUL     (10960): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:12:05.871+0900 I/AUL     (10960): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:12:05.871+0900 E/AUL     (10960): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:12:05.871+0900 E/AUL     (10960): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:12:05.901+0900 I/UXT     (10960): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
05-25 17:12:06.041+0900 E/MALI    (10960): mali_egl_winsys.c: window_surface_new(889) >  Create Window, it runs with MALI_X11_ASYNC_PAGEFLIP 1 
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[3] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[7] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[11] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[15] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[19] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[23] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[27] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[31] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[35] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[39] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[43] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[47] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[51] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[55] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[59] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[63] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[3] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[7] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[11] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[15] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[19] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[23] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[27] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[31] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[35] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[39] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[43] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[47] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[51] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[55] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[59] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[63] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath.c: fastpath_init_context_states(1463) >  [40;31;1mNumber of uniform buffer binding is too big! (64-72)[0m
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
05-25 17:12:06.051+0900 W/CoreGL  (10960): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
05-25 17:12:06.661+0900 E/PKGMGR_SERVER(10894): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=0, queue_status=1] 
05-25 17:12:06.871+0900 E/rpm-installer(10948): rpm-appcore-intf.c: main(273) > ------------------------------------------------
05-25 17:12:06.871+0900 E/rpm-installer(10948): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
05-25 17:12:06.871+0900 E/rpm-installer(10948): rpm-appcore-intf.c: main(275) > ------------------------------------------------
05-25 17:12:06.891+0900 E/PKGMGR_SERVER(10894): pkgmgr-server.c: sighandler(486) > child NORMAL exit [10948]
05-25 17:12:07.141+0900 I/AUL     (10970): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
05-25 17:12:07.161+0900 I/AUL     (10970): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:12:07.161+0900 E/AUL     (10970): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:12:07.161+0900 E/AUL     (10970): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:12:08.661+0900 E/PKGMGR_SERVER(10894): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=1, queue_status=1] 
05-25 17:12:08.661+0900 E/PKGMGR_SERVER(10894): pkgmgr-server.c: main(2281) > package manager server terminated.
05-25 17:12:08.751+0900 W/AUL     (11034): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.clover)
05-25 17:12:08.751+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 0
05-25 17:12:08.761+0900 I/AUL_AMD ( 2490): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
05-25 17:12:08.771+0900 I/AUL_AMD ( 2490): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
05-25 17:12:08.771+0900 E/AUL_AMD ( 2490): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
05-25 17:12:08.771+0900 W/AUL_AMD ( 2490): amd_launch.c: _start_app(1782) > caller pid : 11034
05-25 17:12:08.791+0900 E/RESOURCED( 2613): block.c: block_prelaunch_state(138) > insert data org.example.clover, table num : 3
05-25 17:12:08.791+0900 W/AUL_AMD ( 2490): amd_launch.c: _start_app(2218) > pad pid(-5)
05-25 17:12:08.791+0900 W/AUL_PAD ( 3264): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
05-25 17:12:08.791+0900 W/AUL_PAD ( 3264): launchpad.c: __send_result_to_caller(272) > Check app launching
05-25 17:12:08.791+0900 W/AUL_PAD (10958): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
05-25 17:12:08.791+0900 W/AUL_PAD (10958): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
05-25 17:12:08.791+0900 W/AUL_PAD (10958): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
05-25 17:12:08.791+0900 W/AUL_PAD (10958): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.clover)
05-25 17:12:08.851+0900 I/efl-extension(10958): efl_extension.c: eext_mod_init(40) > Init
05-25 17:12:08.851+0900 W/AUL_PAD (10958): launchpad_loader.c: main(690) > [candidate] dlsym
05-25 17:12:08.851+0900 W/AUL_PAD (10958): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.clover)
05-25 17:12:08.851+0900 I/CAPI_APPFW_APPLICATION(10958): app_main.c: ui_app_main(704) > app_efl_main
05-25 17:12:08.851+0900 I/CAPI_APPFW_APPLICATION(10958): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-25 17:12:08.891+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.clover) pid(10958) type(uiapp) bg(0)
05-25 17:12:08.891+0900 W/AUL_AMD ( 2490): amd_status.c: __socket_monitor_cb(1277) > (10958) was created
05-25 17:12:08.891+0900 W/AUL     (11034): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10958)
05-25 17:12:08.891+0900 W/STARTER ( 2650): pkg-monitor.c: _app_mgr_status_cb(394) > [_app_mgr_status_cb:394] Launch request [10958]
05-25 17:12:08.951+0900 E/EFL     (10958): ecore_evas<10958> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-25 17:12:08.971+0900 W/W_HOME  ( 2724): event_manager.c: _ecore_x_message_cb(428) > state: 0 -> 1
05-25 17:12:08.971+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:12:08.971+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:12:08.971+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:12:08.971+0900 W/W_HOME  ( 2724): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 0
05-25 17:12:08.971+0900 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
05-25 17:12:08.981+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
05-25 17:12:09.011+0900 E/EFL     (10958): elementary<10958> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
05-25 17:12:09.021+0900 E/EFL     (10958): elementary<10958> elc_naviframe.c:2950 elm_naviframe_item_push() item(0xf78313f0) will be pushed
05-25 17:12:09.051+0900 E/TIZEN_N_RECORDER(10958): recorder.c: __convert_recorder_error_code(193) > [audio-channel] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:12:09.051+0900 E/TIZEN_N_RECORDER(10958): recorder.c: __convert_recorder_error_code(193) > [audio-device] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:12:09.051+0900 I/APP_CORE(10958): appcore-efl.c: __do_app(453) > [APP 10958] Event: RESET State: CREATED
05-25 17:12:09.051+0900 I/CAPI_APPFW_APPLICATION(10958): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-25 17:12:09.061+0900 I/APP_CORE(10958): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
05-25 17:12:09.071+0900 I/APP_CORE(10958): appcore-efl.c: __do_app(524) > [APP 10958] Initial Launching, call the resume_cb
05-25 17:12:09.071+0900 I/CAPI_APPFW_APPLICATION(10958): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-25 17:12:09.071+0900 W/APP_CORE(10958): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3600002
05-25 17:12:09.131+0900 W/W_HOME  ( 2724): event_manager.c: _window_visibility_cb(473) > Window [0x1E00003] is now visible(1)
05-25 17:12:09.131+0900 W/W_HOME  ( 2724): event_manager.c: _window_visibility_cb(483) > state: 1 -> 0
05-25 17:12:09.131+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:12:09.131+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:12:09.131+0900 W/W_HOME  ( 2724): main.c: _window_visibility_cb(964) > Window [0x1E00003] is now visible(1)
05-25 17:12:09.131+0900 I/APP_CORE(10958): appcore-efl.c: __visibility_cb(937) > LCD status is off, skip the AE_RESUME event
05-25 17:12:09.131+0900 I/APP_CORE( 2724): appcore-efl.c: __do_app(453) > [APP 2724] Event: PAUSE State: PAUSED
05-25 17:12:09.141+0900 I/APP_CORE( 2724): appcore-efl.c: __visibility_cb(949) > LCD status is off, skip the AE_RESUME event
05-25 17:12:09.141+0900 I/wnotib  ( 2724): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
05-25 17:12:09.141+0900 E/wnotib  ( 2724): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-25 17:12:09.141+0900 W/wnotib  ( 2724): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [3], notiboard card appending count [8].
05-25 17:12:09.141+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2724) status(bg) type(uiapp)
05-25 17:12:09.141+0900 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2724] goes to (4)
05-25 17:12:09.141+0900 E/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2724)'s state(4)
05-25 17:12:09.151+0900 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[10958] goes to (3)
05-25 17:12:09.151+0900 W/AUL_AMD ( 2490): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-25 17:12:09.151+0900 W/AUL_AMD ( 2490): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
05-25 17:12:09.151+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.clover) pid(10958) status(fg) type(uiapp)
05-25 17:12:09.511+0900 E/AUL     ( 2490): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
05-25 17:12:09.991+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 14
05-25 17:12:10.001+0900 W/AUL_AMD ( 2490): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10958
05-25 17:12:10.001+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 12
05-25 17:12:10.011+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 14
05-25 17:12:10.021+0900 W/AUL_AMD ( 2490): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10958
05-25 17:12:10.031+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 12
05-25 17:12:10.211+0900 I/AUL_PAD (11040): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
05-25 17:12:11.561+0900 W/SHealthCommon( 2843): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:1[0;m
05-25 17:12:11.561+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [4376.903346] dpms[3 -> 0]sync[0]
05-25 17:12:11.561+0900 I/TDM     ( 1552): 
05-25 17:12:11.561+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [4376.903499] dpms[0 -> 0]done
05-25 17:12:11.561+0900 I/TDM     ( 1552): 
05-25 17:12:11.561+0900 W/SHealthCommon( 3233): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:1[0;m
05-25 17:12:11.581+0900 W/wnotibp ( 3231): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(91) > ::APP:: view state=0, 2, 0
05-25 17:12:11.581+0900 I/wnotibp ( 3231): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(140) > There is no additional work.
05-25 17:12:11.591+0900 W/WATCH_CORE( 2779): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOn
05-25 17:12:11.591+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_lcd_status_handler(1250) > Call the time_tick_cb
05-25 17:12:11.591+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:12:11.591+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_lcd_status_handler(1257) > Call widget_provider_update_event
05-25 17:12:11.591+0900 W/W_HOME  ( 2724): dbus.c: _dbus_message_recv_cb(186) > LCD on
05-25 17:12:11.591+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_disable_timer_set(167) > timer set
05-25 17:12:11.591+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_disable_timer_del(157) > timer del
05-25 17:12:11.591+0900 W/W_HOME  ( 2724): gesture.c: _apps_status_get(128) > apps status:0
05-25 17:12:11.591+0900 W/W_HOME  ( 2724): gesture.c: _lcd_on_cb(303) > move_to_clock:1 clock_visible:0 info->offtime:63207
05-25 17:12:11.591+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_schedule(209) > schedule, manual render
05-25 17:12:11.591+0900 W/W_HOME  ( 2724): event_manager.c: _lcd_on_cb(728) > lcd state: 1
05-25 17:12:11.591+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:12:11.591+0900 W/STARTER ( 2650): clock-mgr.c: _on_lcd_signal_receive_cb(1579) > [_on_lcd_signal_receive_cb:1579] _on_lcd_signal_receive_cb, 1579, Pre LCD on by [unknown] after screen off time [63207]ms
05-25 17:12:11.591+0900 W/STARTER ( 2650): clock-mgr.c: _pre_lcd_on(1298) > [_pre_lcd_on:1298] Will LCD ON as reserved app[(null)] alpm mode[0]
05-25 17:12:11.601+0900 I/APP_CORE(10958): appcore-efl.c: __do_app(453) > [APP 10958] Event: RESUME State: RUNNING
05-25 17:12:11.611+0900 W/W_INDICATOR( 2651): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(285) > [_windicator_dbus_lcd_changed_cb:285] LCD ON signal is received
05-25 17:12:11.611+0900 W/W_INDICATOR( 2651): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] 304, str=[unknown],charge : 0, connected : 0
05-25 17:12:11.611+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : -147223796[0;m
05-25 17:12:11.611+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
05-25 17:12:11.611+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-25 17:12:11.611+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
05-25 17:12:11.611+0900 W/SHealthService( 3233): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-25 17:12:11.621+0900 W/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
05-25 17:12:11.621+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
05-25 17:12:11.621+0900 W/SHealthCommon( 3233): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1495670400000.000000[0;m
05-25 17:12:11.621+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
05-25 17:12:11.621+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
05-25 17:12:11.621+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
05-25 17:12:11.631+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
05-25 17:12:11.631+0900 W/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-25 17:12:11.631+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
05-25 17:12:11.631+0900 I/HIGEAR  ( 3216): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
05-25 17:12:11.631+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_set_info(1442) > [4376.975239] layer(0x874fb8) not usable
05-25 17:12:11.631+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_set_info(1459) > [4376.975274] layer(0x874fb8) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
05-25 17:12:11.631+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_layer_set_info(1578) > [4376.975295] layer[0x874b08]zpos[1]
05-25 17:12:11.631+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_set_info(1442) > [4376.975389] layer(0x875008) not usable
05-25 17:12:11.631+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_set_info(1459) > [4376.975404] layer(0x875008) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
05-25 17:12:11.631+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_layer_set_info(1578) > [4376.975421] layer[0x874c28]zpos[2]
05-25 17:12:11.641+0900 W/W_HOME  ( 2724): gesture.c: _widget_updated_cb(188) > widget updated
05-25 17:12:11.641+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_disable_timer_del(157) > timer del
05-25 17:12:11.641+0900 W/W_HOME  ( 2724): gesture.c: _manual_render(182) > 
05-25 17:12:11.671+0900 W/SHealthCommon( 3233): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.widget.hrlog (916859)]][0;m
05-25 17:12:11.671+0900 W/W_HOME  ( 2724): gesture.c: _manual_render(182) > 
05-25 17:12:11.711+0900 W/SHealthCommon( 3233): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.1.30][0;m
05-25 17:12:11.711+0900 W/SHealthWidget( 2843): WidgetMain.cpp: widget_update(147) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.widget.hrlog (916859), msgName: timeline_summary_updated[0;m
05-25 17:12:11.711+0900 W/SHealthCommon( 2843): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
05-25 17:12:11.711+0900 W/SHealthWidget( 2843): HrLogWidgetViewController.cpp: OnIpcProxyMessageReceived(71) > [1;35m##24Hour Widget Service SummaryUpdate Called[0;m
05-25 17:12:11.711+0900 W/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1495732331724.000000, pattern:[HH:mm][0;m
05-25 17:12:11.711+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-25 17:12:11.711+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-25 17:12:11.711+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-25 17:12:11.711+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-25 17:12:11.711+0900 E/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale ko_KR[0;m
05-25 17:12:11.711+0900 W/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:12][0;m
05-25 17:12:11.711+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-25 17:12:11.711+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-25 17:12:11.711+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-25 17:12:11.711+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-25 17:12:11.711+0900 I/CAPI_WIDGET_APPLICATION( 2843): widget_app.c: __provider_update_cb(281) > received updating signal
05-25 17:12:11.731+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_enable(138) > 0
05-25 17:12:11.761+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
05-25 17:12:11.771+0900 I/efl-extension( 2724): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-25 17:12:11.771+0900 I/efl-extension( 3231): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-25 17:12:11.771+0900 I/efl-extension( 3265): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-25 17:12:11.771+0900 I/efl-extension( 3070): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-25 17:12:11.781+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
05-25 17:12:11.781+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: preference_get_boolean(1173) > preference_get_boolean(3233) : test_healthy_pace error
05-25 17:12:11.801+0900 I/HealthDataService( 2909): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-25 17:12:11.831+0900 W/STARTER ( 2650): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [unknown]
05-25 17:12:11.831+0900 W/STARTER ( 2650): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[0]
05-25 17:12:11.841+0900 I/healthData( 3233): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
05-25 17:12:11.841+0900 W/SHealthCommon( 3233): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1495670400000.000000[0;m
05-25 17:12:11.861+0900 W/SHealthCommon( 3233): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.widget.hrlog (916859)]][0;m
05-25 17:12:11.881+0900 W/SHealthCommon( 3233): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.1.30][0;m
05-25 17:12:11.881+0900 W/SHealthWidget( 2843): WidgetMain.cpp: widget_update(147) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.widget.hrlog (916859), msgName: timeline_summary_updated[0;m
05-25 17:12:11.881+0900 W/SHealthCommon( 2843): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
05-25 17:12:11.881+0900 W/SHealthWidget( 2843): HrLogWidgetViewController.cpp: OnIpcProxyMessageReceived(71) > [1;35m##24Hour Widget Service SummaryUpdate Called[0;m
05-25 17:12:11.891+0900 W/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1495732331898.000000, pattern:[HH:mm][0;m
05-25 17:12:11.891+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-25 17:12:11.891+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-25 17:12:11.891+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-25 17:12:11.891+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-25 17:12:11.891+0900 E/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale ko_KR[0;m
05-25 17:12:11.891+0900 W/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:12][0;m
05-25 17:12:11.891+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-25 17:12:11.891+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-25 17:12:11.891+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-25 17:12:11.891+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-25 17:12:11.891+0900 I/CAPI_WIDGET_APPLICATION( 2843): widget_app.c: __provider_update_cb(281) > received updating signal
05-25 17:12:11.891+0900 I/HealthDataService( 2909): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-25 17:12:11.901+0900 I/healthData( 3233): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
05-25 17:12:13.501+0900 E/EFL     (10958): ecore_x<10958> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=4378840 button=1
05-25 17:12:13.571+0900 E/EFL     (10958): ecore_x<10958> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=4378916 button=1
05-25 17:12:13.651+0900 I/USR_TAG (10958): record_start
05-25 17:12:13.651+0900 E/TIZEN_N_RECORDER(10958): recorder.c: __convert_recorder_error_code(193) > [recorder_attr_set_time_limit] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:12:13.651+0900 E/TIZEN_N_RECORDER(10958): recorder.c: __convert_recorder_error_code(193) > [recorder_set_filename] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:12:13.651+0900 E/TIZEN_N_RECORDER(10958): recorder.c: __convert_recorder_error_code(193) > [file-format] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:12:13.651+0900 E/TIZEN_N_RECORDER(10958): recorder.c: __convert_recorder_error_code(193) > [audio-encoder] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:12:13.941+0900 E/TIZEN_N_RECORDER(10958): recorder.c: __convert_recorder_error_code(193) > [recorder_start] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:12:13.941+0900 E/EFL     (10958): <10958> elm_main.c:1300 elm_object_disabled_set() safety check failed: obj == NULL
05-25 17:12:13.941+0900 E/EFL     (10958): <10958> elm_main.c:1300 elm_object_disabled_set() safety check failed: obj == NULL
05-25 17:12:13.951+0900 E/EFL     (10958): elementary<10958> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
05-25 17:12:13.971+0900 E/EFL     (10958): elementary<10958> elc_naviframe.c:2950 elm_naviframe_item_push() item(0xf217cbf8) will be pushed
05-25 17:12:13.971+0900 E/EFL     (10958): elementary<10958> elc_naviframe.c:2796 _push_transition_cb() item(0xf217cbf8) will transition
05-25 17:12:14.181+0900 E/WMS     ( 2450): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23510) > _wms_event_handler_cb_nomove_detector is called
05-25 17:12:14.411+0900 E/EFL     (10958): elementary<10958> elc_naviframe.c:1193 _on_item_push_finished() item(0xf78313f0) transition finished
05-25 17:12:14.411+0900 E/EFL     (10958): elementary<10958> elc_naviframe.c:1218 _on_item_show_finished() item(0xf217cbf8) transition finished
05-25 17:12:14.581+0900 E/EFL     ( 2318): ecore_x<2318> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x3600002 time=4379319
05-25 17:12:14.581+0900 E/EFL     (10958): ecore_x<10958> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=4379319
05-25 17:12:14.581+0900 E/EFL     ( 2318): ecore_x<2318> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=4379319
05-25 17:12:14.941+0900 I/USR_TAG (10958): loud sound is detected!
05-25 17:12:14.971+0900 E/TIZEN_N_RECORDER(10958): recorder.c: __convert_recorder_error_code(193) > [recorder_cancel] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:12:14.971+0900 I/USR_TAG (10958): recorder_cancel-4150005019334361762916908065143907923227341906360163421155217113092941601026010143668951250630646044897948554019319627504666194693592752219099525630890956392847650312284065728343804882449961331409042582887957891437534973258315943204809238316567975284696437227520.000000
05-25 17:12:14.991+0900 E/TIZEN_N_RECORDER(10958): recorder.c: __convert_recorder_error_code(193) > [recorder_unprepare] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:12:14.991+0900 I/USR_TAG (10958): record_start
05-25 17:12:14.991+0900 I/USR_TAG (10958): recording for a loud sound
05-25 17:12:14.991+0900 E/TIZEN_N_RECORDER(10958): recorder.c: __convert_recorder_error_code(193) > [recorder_attr_set_time_limit] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:12:14.991+0900 E/TIZEN_N_RECORDER(10958): recorder.c: __convert_recorder_error_code(193) > [recorder_set_filename] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:12:14.991+0900 E/TIZEN_N_RECORDER(10958): recorder.c: __convert_recorder_error_code(193) > [file-format] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:12:14.991+0900 E/TIZEN_N_RECORDER(10958): recorder.c: __convert_recorder_error_code(193) > [audio-encoder] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:12:15.311+0900 E/TIZEN_N_RECORDER(10958): recorder.c: __convert_recorder_error_code(193) > [recorder_start] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:12:15.311+0900 E/EFL     (10958): <10958> elm_main.c:1300 elm_object_disabled_set() safety check failed: obj == NULL
05-25 17:12:15.311+0900 E/EFL     (10958): <10958> elm_main.c:1300 elm_object_disabled_set() safety check failed: obj == NULL
05-25 17:12:18.331+0900 I/USR_TAG (10958): record_stop
05-25 17:12:18.441+0900 E/TIZEN_N_RECORDER(10958): recorder.c: __convert_recorder_error_code(193) > [recorder_commit] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:12:18.441+0900 E/TIZEN_N_RECORDER(10958): recorder.c: __convert_recorder_error_code(193) > [recorder_unprepare] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:12:18.441+0900 E/EFL     (10958): <10958> elm_main.c:1300 elm_object_disabled_set() safety check failed: obj == NULL
05-25 17:12:18.451+0900 E/EFL     (10958): <10958> elm_main.c:1300 elm_object_disabled_set() safety check failed: obj == NULL
05-25 17:12:19.131+0900 I/USR_TAG (10958): recv:car
05-25 17:12:19.451+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 10958 pgid = 10958
05-25 17:12:19.451+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
05-25 17:12:19.491+0900 W/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
05-25 17:12:19.491+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
05-25 17:12:19.491+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:12:19.491+0900 W/AUL_AMD ( 2490): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-25 17:12:19.491+0900 W/AUL_AMD ( 2490): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
05-25 17:12:19.491+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2724) status(fg) type(uiapp)
05-25 17:12:19.511+0900 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2724] goes to (3)
05-25 17:12:19.511+0900 E/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2724)'s state(3)
05-25 17:12:19.531+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
05-25 17:12:19.531+0900 I/AUL_AMD ( 2490): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10958
05-25 17:12:19.541+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(10958)
05-25 17:12:19.561+0900 W/PROCESSMGR( 2318): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
05-25 17:12:19.561+0900 W/W_HOME  ( 2724): event_manager.c: _ecore_x_message_cb(428) > state: 1 -> 0
05-25 17:12:19.561+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:12:19.561+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:12:19.561+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:12:19.561+0900 W/W_HOME  ( 2724): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
05-25 17:12:19.581+0900 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
05-25 17:12:19.591+0900 W/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
05-25 17:12:19.591+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
05-25 17:12:19.591+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:12:19.591+0900 W/CRASH_MANAGER(11064): worker.c: worker_job(1199) > 1110958636c6f149569993

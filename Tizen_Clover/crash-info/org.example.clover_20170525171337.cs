S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.1
Build-Number: R760XXU1APL2
Build-Date: 2016.12.20 22:57:01

Crash Information
Process Name: clover
PID: 11308
Date: 2017-05-25 17:13:37+0900
Executable File Path: /opt/usr/apps/org.example.clover/bin/clover
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 11308, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0xf5ca82c0, r3   = 0x00000001
r4   = 0xf70709b8, r5   = 0xf70709b8
r6   = 0xf707016c, r7   = 0xfff3d630
r8   = 0xf70709b8, r9   = 0xf76dfb80
r10  = 0xf707eb10, fp   = 0x00000000
ip   = 0xf5ca8300, sp   = 0xfff3d5e0
lr   = 0xf6e345d0, pc   = 0xf5c94562
cpsr = 0x60000030

Memory Information
MemTotal:   714608 KB
MemFree:     16184 KB
Buffers:     32192 KB
Cached:     168312 KB
VmPeak:     189976 KB
VmSize:     189972 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       37168 KB
VmRSS:       37164 KB
VmData:     111932 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       29384 KB
VmPTE:         188 KB
VmSwap:          0 KB

Threads Information
Threads: 11
PID = 11308 TID = 11308
11308 11398 11399 11402 11403 11404 11405 11406 11407 11408 11409 

Maps Information
ecefe000 ed6fd000 rw-p [stack:11409]
ed6fe000 ee2fe000 rw-p [stack:11408]
ee2ff000 eeafe000 rw-p [stack:11407]
eeaff000 ef2fe000 rw-p [stack:11406]
efb01000 f0300000 rw-p [stack:11405]
f0301000 f0b00000 rw-p [stack:11404]
f0cea000 f0ced000 r-xp /usr/lib/gstreamer-0.10/libgstwavenc.so
f0cf5000 f0d0f000 r-xp /usr/lib/gstreamer-0.10/libgstpulse.so
f0d18000 f0d50000 r-xp /usr/lib/libsamrnb.so
f0d73000 f0d7e000 r-xp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
f0d87000 f0d97000 r-xp /usr/lib/gstreamer-0.10/libgstalsa.so
f0d9f000 f0da5000 r-xp /usr/lib/libscmn.so
f0dad000 f0de5000 r-xp /usr/lib/libsaac.so
f0def000 f0df4000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencamrnb.so
f0dfc000 f0e0c000 r-xp /usr/lib/lib_SamsungRec_TizenV04015.so
f0e2d000 f0e35000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
f0e44000 f0e49000 r-xp /usr/lib/gstreamer-0.10/libgstsecrecord.so
f0e5b000 f0e73000 r-xp /usr/lib/libgstcontroller-0.10.so.0.30.0
f0e83000 f0e89000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencaac.so
f0e91000 f0ea9000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
f0eb2000 f0edb000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
f0eed000 f0ef2000 r-xp /usr/lib/gstreamer-0.10/libgstvolume.so
f0efa000 f1058000 r-xp /usr/lib/gstreamer-0.10/libgstffmpeg.so
f1140000 f114c000 r-xp /usr/lib/gstreamer-0.10/libgstencodebin.so
f1154000 f1174000 r-xp /usr/lib/gstreamer-0.10/libgstomx.so
f1175000 f11a9000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
f12b1000 f1ab0000 rw-p [stack:11399]
f1ab1000 f22b0000 rw-p [stack:11398]
f2358000 f2b57000 rw-p [stack:11402]
f2d03000 f2d0e000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
f2d16000 f2d18000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
f2d20000 f2d21000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
f2d29000 f2d31000 r-xp /usr/lib/libfeedback.so.0.1.4
f2d36000 f2d39000 r-xp /usr/lib/gstreamer-0.10/libgstavsysaudiosrc.so
f2d41000 f2d42000 r-xp /usr/lib/gstreamer-0.10/libgstapp.so
f2d4a000 f2d4b000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
f2d53000 f2d54000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
f2dee000 f35ed000 rw-p [stack:11403]
f35ed000 f35ef000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
f35f7000 f360e000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f361b000 f3620000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f3628000 f3633000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f396d000 f3a5f000 r-xp /usr/lib/libCOREGL.so.4.0
f3a78000 f3a7d000 r-xp /usr/lib/libsystem.so.0.0.0
f3a87000 f3a88000 r-xp /usr/lib/libresponse.so.0.2.96
f3a90000 f3a95000 r-xp /usr/lib/libproc-stat.so.0.2.96
f3a9e000 f3aa0000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f3aa8000 f3aaf000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f3ab8000 f3ada000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f3ae3000 f3ae7000 r-xp /usr/lib/libogg.so.0.7.1
f3aef000 f3b11000 r-xp /usr/lib/libvorbis.so.0.4.3
f3b19000 f3b1c000 r-xp /usr/lib/libtinycompress.so.0.0.0
f3b24000 f3b33000 r-xp /usr/lib/libmdm-common.so.1.1.22
f3b3c000 f3b44000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f3b4c000 f3b52000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f3b5b000 f3b62000 r-xp /usr/lib/libminizip.so.1.0.0
f3b6a000 f3b6c000 r-xp /usr/lib/libttrace.so.1.1
f3b74000 f3bbb000 r-xp /usr/lib/libsndfile.so.1.0.26
f3bc7000 f3c10000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f3c19000 f3c1e000 r-xp /usr/lib/libjson.so.0.0.1
f54b7000 f55bd000 r-xp /usr/lib/libicuuc.so.57.1
f55d3000 f575b000 r-xp /usr/lib/libicui18n.so.57.1
f576b000 f5778000 r-xp /usr/lib/libail.so.0.1.0
f5781000 f5784000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f578c000 f578f000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f5797000 f57f8000 r-xp /usr/lib/libasound.so.2.0.0
f5802000 f5818000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f5820000 f5824000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f582c000 f586d000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
f5876000 f5878000 r-xp /usr/lib/libdri2.so.0.0.0
f5880000 f5888000 r-xp /usr/lib/libdrm.so.2.4.0
f5890000 f5896000 r-xp /usr/lib/libxcb-render.so.0.0.0
f589e000 f589f000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f58a8000 f58ac000 r-xp /usr/lib/libEGL.so.1.4
f58bc000 f58cd000 r-xp /usr/lib/libGLESv2.so.2.0
f58dd000 f5925000 r-xp /usr/lib/libmdm.so.1.2.62
f5926000 f592d000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f5935000 f5940000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f594d000 f5966000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f596e000 f5973000 r-xp /usr/lib/libstorage.so.0.1
f597b000 f5980000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f5988000 f59c0000 r-xp /usr/lib/libpulse.so.0.16.2
f59c1000 f59c5000 r-xp /usr/lib/libmmfsession.so.0.0.0
f59ce000 f59e5000 r-xp /usr/lib/libmmfsound.so.0.1.0
f59f7000 f5a18000 r-xp /usr/lib/libexif.so.12.3.3
f5a2b000 f5a34000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
f5a3c000 f5a49000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
f5a52000 f5a5d000 r-xp /usr/lib/libtbm.so.1.0.0
f5a65000 f5a6a000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f5a72000 f5b2a000 r-xp /usr/lib/libcairo.so.2.11200.14
f5b35000 f5bd0000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
f5bdc000 f5c2c000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
f5c32000 f5c44000 r-xp /usr/lib/libcapi-media-camera.so.0.1.35
f5c4c000 f5c6d000 r-xp /usr/lib/libefl-extension.so.0.1.0
f5c75000 f5c7a000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5c82000 f5c8a000 r-xp /usr/lib/libcapi-media-recorder.so.0.1.28
f5c92000 f5c99000 r-xp /opt/usr/apps/org.example.clover/bin/clover
f5e3b000 f5e45000 r-xp /lib/libnss_files-2.13.so
f5e4e000 f5f1d000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f5f33000 f5f57000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f5f60000 f5f66000 r-xp /usr/lib/libappsvc.so.0.1.0
f5f6e000 f5f70000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f5f79000 f5f7d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f5f89000 f5f94000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f5f9c000 f5f9e000 r-xp /usr/lib/libiniparser.so.0
f5fa7000 f5fac000 r-xp /usr/lib/libappcore-common.so.1.1
f5fb4000 f5fb6000 r-xp /usr/lib/libcamsrcjpegenc.so.0.0.0
f5fbe000 f5fc2000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f5fcf000 f5fd1000 r-xp /usr/lib/libXau.so.6.0.0
f5fd9000 f5fe0000 r-xp /lib/libcrypt-2.13.so
f6010000 f6012000 r-xp /usr/lib/libiri.so
f601b000 f61c4000 r-xp /usr/lib/libcrypto.so.1.0.0
f61e4000 f622b000 r-xp /usr/lib/libssl.so.1.0.0
f6237000 f6265000 r-xp /usr/lib/libidn.so.11.5.44
f626d000 f6276000 r-xp /usr/lib/libcares.so.2.1.0
f6280000 f6293000 r-xp /usr/lib/libxcb.so.1.1.0
f629c000 f629e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f62a6000 f62a8000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f62b1000 f637d000 r-xp /usr/lib/libxml2.so.2.7.8
f638a000 f638c000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6395000 f639a000 r-xp /usr/lib/libffi.so.5.0.10
f63a2000 f63a3000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f63ab000 f63ae000 r-xp /lib/libattr.so.1.1.0
f63b6000 f644a000 r-xp /usr/lib/libstdc++.so.6.0.16
f645d000 f647a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6484000 f649c000 r-xp /usr/lib/libpng12.so.0.50.0
f64a4000 f64ba000 r-xp /lib/libexpat.so.1.6.0
f64c4000 f6508000 r-xp /usr/lib/libcurl.so.4.3.0
f6511000 f651b000 r-xp /usr/lib/libXext.so.6.4.0
f6524000 f6528000 r-xp /usr/lib/libXtst.so.6.1.0
f6530000 f6536000 r-xp /usr/lib/libXrender.so.1.3.0
f653e000 f6544000 r-xp /usr/lib/libXrandr.so.2.2.0
f654c000 f654d000 r-xp /usr/lib/libXinerama.so.1.0.0
f6556000 f655f000 r-xp /usr/lib/libXi.so.6.1.0
f6567000 f656a000 r-xp /usr/lib/libXfixes.so.3.1.0
f6572000 f6574000 r-xp /usr/lib/libXgesture.so.7.0.0
f657c000 f657e000 r-xp /usr/lib/libXcomposite.so.1.0.0
f6586000 f6588000 r-xp /usr/lib/libXdamage.so.1.1.0
f6590000 f6597000 r-xp /usr/lib/libXcursor.so.1.0.2
f659f000 f65a2000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f65aa000 f65ae000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f65b7000 f65bc000 r-xp /usr/lib/libecore_fb.so.1.7.99
f65c5000 f66a6000 r-xp /usr/lib/libX11.so.6.3.0
f66b1000 f66d4000 r-xp /usr/lib/libjpeg.so.8.0.2
f66ec000 f6702000 r-xp /lib/libz.so.1.2.5
f670a000 f670c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6714000 f6789000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6793000 f67ad000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f67b5000 f67e9000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f67f2000 f68c5000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68d0000 f68e0000 r-xp /lib/libresolv-2.13.so
f68e4000 f68fc000 r-xp /usr/lib/liblzma.so.5.0.3
f6904000 f6907000 r-xp /lib/libcap.so.2.21
f690f000 f693e000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6946000 f6947000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f694f000 f6955000 r-xp /usr/lib/libecore_imf.so.1.7.99
f695d000 f6974000 r-xp /usr/lib/liblua-5.1.so
f697d000 f6984000 r-xp /usr/lib/libembryo.so.1.7.99
f698c000 f6992000 r-xp /lib/librt-2.13.so
f699b000 f69f1000 r-xp /usr/lib/libpixman-1.so.0.28.2
f69fe000 f6a54000 r-xp /usr/lib/libfreetype.so.6.11.3
f6a60000 f6a88000 r-xp /usr/lib/libfontconfig.so.1.8.0
f6a89000 f6ace000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6ad7000 f6aea000 r-xp /usr/lib/libfribidi.so.0.3.1
f6af2000 f6b0c000 r-xp /usr/lib/libecore_con.so.1.7.99
f6b15000 f6b1e000 r-xp /usr/lib/libedbus.so.1.7.99
f6b26000 f6b76000 r-xp /usr/lib/libecore_x.so.1.7.99
f6b78000 f6b81000 r-xp /usr/lib/libvconf.so.0.2.45
f6b89000 f6b9a000 r-xp /usr/lib/libecore_input.so.1.7.99
f6ba2000 f6ba7000 r-xp /usr/lib/libecore_file.so.1.7.99
f6baf000 f6bd1000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6bda000 f6c1b000 r-xp /usr/lib/libeina.so.1.7.99
f6c24000 f6c3d000 r-xp /usr/lib/libeet.so.1.7.99
f6c4e000 f6cb7000 r-xp /lib/libm-2.13.so
f6cc0000 f6cc6000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ccf000 f6cd0000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6cd8000 f6cfb000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d03000 f6d08000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d10000 f6d3a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6d43000 f6d5a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6d62000 f6d6d000 r-xp /lib/libunwind.so.8.0.1
f6d9a000 f6db8000 r-xp /usr/lib/libsystemd.so.0.4.0
f6dc2000 f6ee6000 r-xp /lib/libc-2.13.so
f6ef4000 f6efc000 r-xp /lib/libgcc_s-4.6.so.1
f6efd000 f6f01000 r-xp /usr/lib/libsmack.so.1.0.0
f6f0a000 f6f10000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f6f18000 f6fe8000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6fe9000 f7047000 r-xp /usr/lib/libedje.so.1.7.99
f7051000 f7068000 r-xp /usr/lib/libecore.so.1.7.99
f707f000 f714d000 r-xp /usr/lib/libevas.so.1.7.99
f7172000 f72ae000 r-xp /usr/lib/libelementary.so.1.7.99
f72c5000 f72d9000 r-xp /lib/libpthread-2.13.so
f72e4000 f72e6000 r-xp /usr/lib/libdlog.so.0.0.0
f72ee000 f72f1000 r-xp /usr/lib/libbundle.so.0.1.22
f72f9000 f72fb000 r-xp /lib/libdl-2.13.so
f7304000 f7311000 r-xp /usr/lib/libaul.so.0.1.0
f7322000 f7328000 r-xp /usr/lib/libappcore-efl.so.1.1
f7331000 f7335000 r-xp /usr/lib/libsys-assert.so
f733e000 f735b000 r-xp /lib/ld-2.13.so
f7364000 f7369000 r-xp /usr/bin/launchpad-loader
f76a7000 f7837000 rw-p [heap]
fff1e000 fff3f000 rw-p [stack]
End of Maps Information

Callstack Information (PID:11308)
Call Stack Count: 12
 0: ecore_timer_cb + 0xc9 (0xf5c94562) [/opt/usr/apps/org.example.clover/bin/clover] + 0x2562
 1: (0xf70601f9) [/usr/lib/libecore.so.1] + 0xf1f9
 2: (0xf70602ef) [/usr/lib/libecore.so.1] + 0xf2ef
 3: (0xf705d2f3) [/usr/lib/libecore.so.1] + 0xc2f3
 4: ecore_main_loop_begin + 0x30 (0xf705d879) [/usr/lib/libecore.so.1] + 0xc879
 5: appcore_efl_main + 0x332 (0xf7325b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
 6: ui_app_main + 0xb0 (0xf5fc0421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 7: uib_app_run + 0xea (0xf5c94f23) [/opt/usr/apps/org.example.clover/bin/clover] + 0x2f23
 8: main + 0x34 (0xf5c94489) [/opt/usr/apps/org.example.clover/bin/clover] + 0x2489
 9: (0xf7365a53) [/opt/usr/apps/org.example.clover/bin/clover] + 0x1a53
10: __libc_start_main + 0x114 (0xf6dd985c) [/lib/libc.so.6] + 0x1785c
11: (0xf7365e0c) [/opt/usr/apps/org.example.clover/bin/clover] + 0x1e0c
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
00 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
05-25 17:13:32.931+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
05-25 17:13:32.931+0900 W/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-25 17:13:32.931+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
05-25 17:13:32.931+0900 I/HIGEAR  ( 3216): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
05-25 17:13:32.961+0900 W/SHealthCommon( 3233): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.widget.hrlog (916859)]][0;m
05-25 17:13:32.991+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:13:33.001+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_disable_timer_cb(145) > timeout callback expired
05-25 17:13:33.001+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_enable(138) > 0
05-25 17:13:33.001+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
05-25 17:13:33.021+0900 W/SHealthWidget( 2843): WidgetMain.cpp: widget_update(147) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.widget.hrlog (916859), msgName: timeline_summary_updated[0;m
05-25 17:13:33.021+0900 W/SHealthCommon( 2843): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
05-25 17:13:33.021+0900 W/SHealthWidget( 2843): HrLogWidgetViewController.cpp: OnIpcProxyMessageReceived(71) > [1;35m##24Hour Widget Service SummaryUpdate Called[0;m
05-25 17:13:33.021+0900 W/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1495732413037.000000, pattern:[HH:mm][0;m
05-25 17:13:33.021+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-25 17:13:33.021+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-25 17:13:33.021+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-25 17:13:33.021+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-25 17:13:33.021+0900 E/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale ko_KR[0;m
05-25 17:13:33.021+0900 W/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:13][0;m
05-25 17:13:33.021+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-25 17:13:33.021+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-25 17:13:33.021+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-25 17:13:33.021+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-25 17:13:33.031+0900 I/CAPI_WIDGET_APPLICATION( 2843): widget_app.c: __provider_update_cb(281) > received updating signal
05-25 17:13:33.061+0900 W/STARTER ( 2650): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [unknown]
05-25 17:13:33.061+0900 W/STARTER ( 2650): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[0]
05-25 17:13:33.071+0900 E/rpm-installer(11298): rpm-appcore-intf.c: main(273) > ------------------------------------------------
05-25 17:13:33.071+0900 E/rpm-installer(11298): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
05-25 17:13:33.071+0900 E/rpm-installer(11298): rpm-appcore-intf.c: main(275) > ------------------------------------------------
05-25 17:13:33.091+0900 E/PKGMGR_SERVER(11297): pkgmgr-server.c: sighandler(486) > child NORMAL exit [11298]
05-25 17:13:33.121+0900 E/RESOURCED( 2613): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/11298/oom_score_adj failed
05-25 17:13:33.121+0900 E/RESOURCED( 2613): proc-main.c: resourced_proc_status_change(1504) > Empty pid or process not exists. 11298
05-25 17:13:33.161+0900 W/SHealthCommon( 3233): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.1.30][0;m
05-25 17:13:33.161+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
05-25 17:13:33.161+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
05-25 17:13:33.171+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: preference_get_boolean(1173) > preference_get_boolean(3233) : test_healthy_pace error
05-25 17:13:33.191+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:13:33.191+0900 I/HealthDataService( 2909): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-25 17:13:33.201+0900 I/healthData( 3233): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
05-25 17:13:33.201+0900 W/SHealthCommon( 3233): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1495670400000.000000[0;m
05-25 17:13:33.221+0900 W/SHealthCommon( 3233): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.widget.hrlog (916859)]][0;m
05-25 17:13:33.271+0900 W/SHealthCommon( 3233): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.1.30][0;m
05-25 17:13:33.271+0900 W/SHealthWidget( 2843): WidgetMain.cpp: widget_update(147) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.widget.hrlog (916859), msgName: timeline_summary_updated[0;m
05-25 17:13:33.271+0900 W/SHealthCommon( 2843): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
05-25 17:13:33.271+0900 W/SHealthWidget( 2843): HrLogWidgetViewController.cpp: OnIpcProxyMessageReceived(71) > [1;35m##24Hour Widget Service SummaryUpdate Called[0;m
05-25 17:13:33.271+0900 W/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1495732413288.000000, pattern:[HH:mm][0;m
05-25 17:13:33.271+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-25 17:13:33.271+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-25 17:13:33.271+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-25 17:13:33.271+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-25 17:13:33.281+0900 E/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale ko_KR[0;m
05-25 17:13:33.281+0900 W/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:13][0;m
05-25 17:13:33.281+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-25 17:13:33.281+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-25 17:13:33.281+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-25 17:13:33.281+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-25 17:13:33.281+0900 I/CAPI_WIDGET_APPLICATION( 2843): widget_app.c: __provider_update_cb(281) > received updating signal
05-25 17:13:33.281+0900 I/HealthDataService( 2909): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-25 17:13:33.301+0900 I/healthData( 3233): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
05-25 17:13:33.391+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:13:33.601+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:13:33.771+0900 I/AUL     (11320): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
05-25 17:13:33.781+0900 I/AUL     (11320): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:13:33.781+0900 E/AUL     (11320): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:13:33.781+0900 E/AUL     (11320): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:13:33.791+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:13:33.811+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-25 17:13:33.821+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-25 17:13:33.821+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-25 17:13:33.821+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-25 17:13:33.821+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-25 17:13:33.821+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-25 17:13:33.821+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-25 17:13:33.821+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:13:33.821+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-25 17:13:33.821+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-25 17:13:33.821+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-25 17:13:33.821+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-25 17:13:33.821+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
05-25 17:13:33.821+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-25 17:13:33.821+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-25 17:13:33.821+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-25 17:13:33.821+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-25 17:13:33.821+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:13:33.821+0900 E/CAPI_APPFW_APP_CONTROL( 2895): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-25 17:13:33.821+0900 W/MUSIC_CONTROL_SERVICE( 2895): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:2895]   [com.samsung.w-home]register msg port [true][0m
05-25 17:13:33.821+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 14
05-25 17:13:33.831+0900 W/AUL_AMD ( 2490): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 2724
05-25 17:13:33.841+0900 W/MUSIC_CONTROL_SERVICE( 2895): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:2895]   [MUSIC_PLAYER_EVENT][0m
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:13:33.841+0900 W/MUSIC_CONTROL_SERVICE( 2895): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:2895]   [MUSIC_PLAYER_EVENT][0m
05-25 17:13:33.841+0900 W/W_HOME  ( 2724): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-25 17:13:33.841+0900 E/W_HOME  ( 2724): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:13:33.841+0900 W/W_HOME  ( 2724): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-25 17:13:33.841+0900 E/W_HOME  ( 2724): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-25 17:13:33.841+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-25 17:13:33.851+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-25 17:13:33.851+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
05-25 17:13:33.851+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-25 17:13:33.851+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-25 17:13:33.851+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-25 17:13:33.851+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-25 17:13:33.851+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:13:33.991+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:13:34.191+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:13:34.241+0900 W/AUL     (11395): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.clover)
05-25 17:13:34.241+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 0
05-25 17:13:34.261+0900 I/AUL_AMD ( 2490): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
05-25 17:13:34.281+0900 I/AUL_AMD ( 2490): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
05-25 17:13:34.281+0900 E/AUL_AMD ( 2490): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
05-25 17:13:34.281+0900 W/AUL_AMD ( 2490): amd_launch.c: _start_app(1782) > caller pid : 11395
05-25 17:13:34.301+0900 E/RESOURCED( 2613): block.c: block_prelaunch_state(138) > insert data org.example.clover, table num : 3
05-25 17:13:34.301+0900 W/AUL_AMD ( 2490): amd_launch.c: _start_app(2218) > pad pid(-5)
05-25 17:13:34.301+0900 W/AUL_PAD ( 3264): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
05-25 17:13:34.301+0900 W/AUL_PAD ( 3264): launchpad.c: __send_result_to_caller(272) > Check app launching
05-25 17:13:34.311+0900 W/AUL_PAD (11308): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
05-25 17:13:34.311+0900 W/AUL_PAD (11308): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
05-25 17:13:34.311+0900 W/AUL_PAD (11308): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
05-25 17:13:34.311+0900 W/AUL_PAD (11308): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.clover)
05-25 17:13:34.381+0900 I/efl-extension(11308): efl_extension.c: eext_mod_init(40) > Init
05-25 17:13:34.381+0900 W/AUL_PAD (11308): launchpad_loader.c: main(690) > [candidate] dlsym
05-25 17:13:34.381+0900 W/AUL_PAD (11308): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.clover)
05-25 17:13:34.381+0900 I/CAPI_APPFW_APPLICATION(11308): app_main.c: ui_app_main(704) > app_efl_main
05-25 17:13:34.381+0900 I/CAPI_APPFW_APPLICATION(11308): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-25 17:13:34.391+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:13:34.401+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.clover) pid(11308) type(uiapp) bg(0)
05-25 17:13:34.411+0900 W/AUL_AMD ( 2490): amd_status.c: __socket_monitor_cb(1277) > (11308) was created
05-25 17:13:34.411+0900 W/AUL     (11395): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11308)
05-25 17:13:34.451+0900 W/STARTER ( 2650): pkg-monitor.c: _app_mgr_status_cb(394) > [_app_mgr_status_cb:394] Launch request [11308]
05-25 17:13:34.521+0900 E/EFL     (11308): ecore_evas<11308> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-25 17:13:34.531+0900 W/W_HOME  ( 2724): event_manager.c: _ecore_x_message_cb(428) > state: 0 -> 1
05-25 17:13:34.531+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:13:34.531+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:13:34.531+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:13:34.531+0900 W/W_HOME  ( 2724): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 0
05-25 17:13:34.531+0900 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
05-25 17:13:34.541+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
05-25 17:13:34.591+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:13:34.611+0900 E/EFL     (11308): elementary<11308> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
05-25 17:13:34.621+0900 E/EFL     (11308): elementary<11308> elc_naviframe.c:2950 elm_naviframe_item_push() item(0xf2c351c0) will be pushed
05-25 17:13:34.661+0900 E/PKGMGR_SERVER(11297): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=1, queue_status=1] 
05-25 17:13:34.661+0900 E/PKGMGR_SERVER(11297): pkgmgr-server.c: main(2281) > package manager server terminated.
05-25 17:13:34.681+0900 E/TIZEN_N_RECORDER(11308): recorder.c: __convert_recorder_error_code(193) > [audio-channel] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:13:34.681+0900 E/TIZEN_N_RECORDER(11308): recorder.c: __convert_recorder_error_code(193) > [audio-device] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:13:34.681+0900 I/APP_CORE(11308): appcore-efl.c: __do_app(453) > [APP 11308] Event: RESET State: CREATED
05-25 17:13:34.681+0900 I/CAPI_APPFW_APPLICATION(11308): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-25 17:13:34.701+0900 I/APP_CORE(11308): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
05-25 17:13:34.701+0900 I/APP_CORE(11308): appcore-efl.c: __do_app(524) > [APP 11308] Initial Launching, call the resume_cb
05-25 17:13:34.701+0900 I/CAPI_APPFW_APPLICATION(11308): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-25 17:13:34.711+0900 W/APP_CORE(11308): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3600002
05-25 17:13:34.761+0900 W/W_HOME  ( 2724): event_manager.c: _window_visibility_cb(473) > Window [0x1E00003] is now visible(1)
05-25 17:13:34.761+0900 W/W_HOME  ( 2724): event_manager.c: _window_visibility_cb(483) > state: 1 -> 0
05-25 17:13:34.761+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:13:34.761+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:13:34.761+0900 W/W_HOME  ( 2724): main.c: _window_visibility_cb(964) > Window [0x1E00003] is now visible(1)
05-25 17:13:34.761+0900 I/APP_CORE( 2724): appcore-efl.c: __do_app(453) > [APP 2724] Event: PAUSE State: RUNNING
05-25 17:13:34.761+0900 I/CAPI_APPFW_APPLICATION( 2724): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-25 17:13:34.761+0900 W/W_HOME  ( 2724): main.c: _appcore_pause_cb(488) > appcore pause
05-25 17:13:34.761+0900 W/W_HOME  ( 2724): event_manager.c: _app_pause_cb(397) > state: 1 -> 2
05-25 17:13:34.761+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:13:34.771+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:13:34.771+0900 W/W_HOME  ( 2724): main.c: home_pause(547) > clock/widget paused
05-25 17:13:34.771+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:13:34.771+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-25 17:13:34.771+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-25 17:13:34.771+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-25 17:13:34.771+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-25 17:13:34.771+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-25 17:13:34.771+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-25 17:13:34.771+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-25 17:13:34.771+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:13:34.771+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-25 17:13:34.771+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-25 17:13:34.771+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-25 17:13:34.771+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-25 17:13:34.771+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
05-25 17:13:34.771+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-25 17:13:34.771+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-25 17:13:34.771+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-25 17:13:34.771+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-25 17:13:34.771+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:13:34.771+0900 E/CAPI_APPFW_APP_CONTROL( 2895): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-25 17:13:34.771+0900 W/MUSIC_CONTROL_SERVICE( 2895): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:2895]   [com.samsung.w-home]register msg port [false][0m
05-25 17:13:34.771+0900 I/wnotib  ( 2724): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
05-25 17:13:34.771+0900 E/wnotib  ( 2724): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-25 17:13:34.771+0900 W/wnotib  ( 2724): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [3], notiboard card appending count [8].
05-25 17:13:34.771+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2724) status(bg) type(uiapp)
05-25 17:13:34.781+0900 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2724] goes to (4)
05-25 17:13:34.781+0900 E/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2724)'s state(4)
05-25 17:13:34.781+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_unset_buffer(1602) > [4460.124071] layer(0x874f48) now usable
05-25 17:13:34.781+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [4460.124099] layer[0x8749e8]zpos[0]
05-25 17:13:34.781+0900 W/WATCH_CORE( 2779): appcore-watch.c: __widget_pause(1113) > widget_pause
05-25 17:13:34.781+0900 W/AUL     ( 2779): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.chronograph16) pid(2779) status(bg) type(watchapp)
05-25 17:13:34.781+0900 D/chronograph( 2779): ChronographApp.cpp: _appPause(150) > [0;34m>>>HIT<<<[0;m
05-25 17:13:34.781+0900 W/chronograph( 2779): ChronographViewController.cpp: onPause(183) > [0;35mState is Pause[isPaused=1], StopwatchState=0[0;m
05-25 17:13:34.781+0900 W/chronograph( 2779): ChronographSweepSecond.cpp: resetSweepSecond(103) > [0;35mresetSweepSecond >>>>[0;m
05-25 17:13:34.781+0900 D/chronograph( 2779): ChronographSweepSecond.cpp: resetSweepSecond(107) > Stop and Clear sweepAnimation !!
05-25 17:13:34.781+0900 D/chronograph-common( 2779): ChronographSensor.cpp: disableAcceleormeter(52) > [0;32mBEGIN >>>>[0;m
05-25 17:13:34.781+0900 D/chronograph-common( 2779): ChronographSensor.cpp: _stopAccelerometer(129) > [0;32mBEGIN >>>>[0;m
05-25 17:13:34.791+0900 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[11308] goes to (3)
05-25 17:13:34.791+0900 W/AUL_AMD ( 2490): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-25 17:13:34.791+0900 W/AUL_AMD ( 2490): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
05-25 17:13:34.791+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.clover) pid(11308) status(fg) type(uiapp)
05-25 17:13:34.811+0900 I/APP_CORE(11308): appcore-efl.c: __do_app(453) > [APP 11308] Event: RESUME State: RUNNING
05-25 17:13:34.811+0900 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
05-25 17:13:34.811+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
05-25 17:13:35.171+0900 E/AUL     ( 2490): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
05-25 17:13:35.271+0900 I/APP_CORE( 2724): appcore-efl.c: __do_app(453) > [APP 2724] Event: MEM_FLUSH State: PAUSED
05-25 17:13:35.491+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 14
05-25 17:13:35.501+0900 W/AUL_AMD ( 2490): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11308
05-25 17:13:35.501+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 14
05-25 17:13:35.521+0900 W/AUL_AMD ( 2490): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11308
05-25 17:13:35.521+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 12
05-25 17:13:35.521+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 12
05-25 17:13:35.701+0900 I/AUL_PAD (11401): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
05-25 17:13:36.541+0900 E/EFL     (11308): ecore_x<11308> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=4461878 button=1
05-25 17:13:36.681+0900 E/EFL     (11308): ecore_x<11308> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=4462016 button=1
05-25 17:13:36.751+0900 I/USR_TAG (11308): record_start
05-25 17:13:36.751+0900 E/TIZEN_N_RECORDER(11308): recorder.c: __convert_recorder_error_code(193) > [recorder_attr_set_time_limit] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:13:36.751+0900 E/TIZEN_N_RECORDER(11308): recorder.c: __convert_recorder_error_code(193) > [recorder_set_filename] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:13:36.751+0900 E/TIZEN_N_RECORDER(11308): recorder.c: __convert_recorder_error_code(193) > [file-format] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:13:36.751+0900 E/TIZEN_N_RECORDER(11308): recorder.c: __convert_recorder_error_code(193) > [audio-encoder] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:13:37.031+0900 E/TIZEN_N_RECORDER(11308): recorder.c: __convert_recorder_error_code(193) > [recorder_start] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:13:37.031+0900 E/EFL     (11308): <11308> elm_main.c:1300 elm_object_disabled_set() safety check failed: obj == NULL
05-25 17:13:37.031+0900 E/EFL     (11308): <11308> elm_main.c:1300 elm_object_disabled_set() safety check failed: obj == NULL
05-25 17:13:37.041+0900 E/EFL     (11308): elementary<11308> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
05-25 17:13:37.061+0900 E/EFL     (11308): elementary<11308> elc_naviframe.c:2950 elm_naviframe_item_push() item(0xf2cb1f68) will be pushed
05-25 17:13:37.071+0900 E/EFL     (11308): elementary<11308> elc_naviframe.c:2796 _push_transition_cb() item(0xf2cb1f68) will transition
05-25 17:13:37.501+0900 E/EFL     (11308): elementary<11308> elc_naviframe.c:1193 _on_item_push_finished() item(0xf2c351c0) transition finished
05-25 17:13:37.501+0900 E/EFL     (11308): elementary<11308> elc_naviframe.c:1218 _on_item_show_finished() item(0xf2cb1f68) transition finished
05-25 17:13:37.631+0900 I/USR_TAG (11308): loud sound is detected!
05-25 17:13:37.681+0900 E/EFL     ( 2318): ecore_x<2318> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x3600002 time=4462408
05-25 17:13:37.971+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 11308 pgid = 11308
05-25 17:13:37.971+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
05-25 17:13:37.981+0900 W/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
05-25 17:13:37.981+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
05-25 17:13:37.981+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:13:37.981+0900 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2724] goes to (3)
05-25 17:13:37.981+0900 E/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2724)'s state(3)
05-25 17:13:37.981+0900 W/AUL_AMD ( 2490): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-25 17:13:37.981+0900 W/AUL_AMD ( 2490): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
05-25 17:13:37.981+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2724) status(fg) type(uiapp)
05-25 17:13:38.041+0900 W/PROCESSMGR( 2318): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
05-25 17:13:38.041+0900 W/W_HOME  ( 2724): event_manager.c: _ecore_x_message_cb(428) > state: 1 -> 0
05-25 17:13:38.041+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:13:38.041+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:13:38.041+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:13:38.041+0900 W/W_HOME  ( 2724): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
05-25 17:13:38.051+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
05-25 17:13:38.051+0900 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
05-25 17:13:38.061+0900 I/AUL_AMD ( 2490): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 11308
05-25 17:13:38.061+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(11308)
05-25 17:13:38.081+0900 W/W_HOME  ( 2724): event_manager.c: _window_visibility_cb(473) > Window [0x1E00003] is now visible(0)
05-25 17:13:38.081+0900 W/W_HOME  ( 2724): event_manager.c: _window_visibility_cb(483) > state: 0 -> 1
05-25 17:13:38.081+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:13:38.081+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:13:38.081+0900 W/W_HOME  ( 2724): main.c: _window_visibility_cb(964) > Window [0x1E00003] is now visible(0)
05-25 17:13:38.081+0900 I/APP_CORE( 2724): appcore-efl.c: __do_app(453) > [APP 2724] Event: RESUME State: PAUSED
05-25 17:13:38.081+0900 I/CAPI_APPFW_APPLICATION( 2724): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-25 17:13:38.081+0900 W/W_HOME  ( 2724): main.c: _appcore_resume_cb(479) > appcore resume
05-25 17:13:38.081+0900 W/W_HOME  ( 2724): event_manager.c: _app_resume_cb(380) > state: 2 -> 1
05-25 17:13:38.081+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:13:38.081+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:13:38.081+0900 W/W_HOME  ( 2724): main.c: home_resume(527) > journal_multimedia_screen_loaded_home called
05-25 17:13:38.081+0900 W/W_HOME  ( 2724): main.c: home_resume(531) > clock/widget resumed
05-25 17:13:38.081+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:13:38.081+0900 I/wnotib  ( 2724): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 0
05-25 17:13:38.081+0900 E/wnotib  ( 2724): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-25 17:13:38.081+0900 W/wnotib  ( 2724): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
05-25 17:13:38.091+0900 W/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
05-25 17:13:38.091+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
05-25 17:13:38.101+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:13:38.101+0900 W/WATCH_CORE( 2779): appcore-watch.c: __widget_resume(1124) > widget_resume
05-25 17:13:38.101+0900 W/AUL     ( 2779): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.chronograph16) pid(2779) status(fg) type(watchapp)
05-25 17:13:38.101+0900 D/chronograph( 2779): ChronographApp.cpp: _appResume(161) > [0;34m>>>HIT<<<[0;m
05-25 17:13:38.101+0900 D/chronograph( 2779): ChronographViewController.cpp: onResume(221) > State is Resume[isPaused=0], StopwatchState=0
05-25 17:13:38.101+0900 W/chronograph( 2779): ChronographSweepSecond.cpp: setSweepSecond(55) > [0;35msetSweepSecond >>>>[0;m
05-25 17:13:38.101+0900 D/chronograph( 2779): ChronographSweepSecond.cpp: setSweepSecond(67) > Current sec = 38, msec = 117
05-25 17:13:38.101+0900 D/chronograph( 2779): ChronographSweepSecond.cpp: setSweepSecond(71) > Create sweepSecondAnimation !!
05-25 17:13:38.101+0900 D/chronograph-common( 2779): ChronographSensor.cpp: enableAccelerometer(44) > [0;32mBEGIN >>>>[0;m
05-25 17:13:38.101+0900 D/chronograph-common( 2779): ChronographSensor.cpp: _startAccelerometer(75) > [0;32mBEGIN >>>>[0;m
05-25 17:13:38.121+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
05-25 17:13:38.141+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:13:38.151+0900 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 1
05-25 17:13:38.161+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_vconfkey_register(416) > [windicator_battery_vconfkey_register:416] Set battery cb
05-25 17:13:38.161+0900 W/W_INDICATOR( 2651): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
05-25 17:13:38.161+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(30), length(2)
05-25 17:13:38.161+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 30%
05-25 17:13:38.161+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 30, isCharging: 0
05-25 17:13:38.161+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_30
05-25 17:13:38.161+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_icon_update(375) > [windicator_battery_icon_update:375] Normal charging status !!
05-25 17:13:38.191+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:13:38.201+0900 W/CRASH_MANAGER(11415): worker.c: worker_job(1199) > 1111308636c6f149570001

S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.1
Build-Number: R760XXU1APL2
Build-Date: 2016.12.20 22:57:01

Crash Information
Process Name: clover
PID: 9374
Date: 2017-05-25 17:02:27+0900
Executable File Path: /opt/usr/apps/org.example.clover/bin/clover
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 9374, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0xf59e626c, r3   = 0x00000001
r4   = 0xf6dae9b8, r5   = 0xf6dae9b8
r6   = 0xf6dae16c, r7   = 0xffbe62c0
r8   = 0xf6dae9b8, r9   = 0xf7581b80
r10  = 0xf6dbcb10, fp   = 0x00000000
ip   = 0xf59e62ac, sp   = 0xffbe6278
lr   = 0xf6b725d0, pc   = 0xf59d2562
cpsr = 0x60000030

Memory Information
MemTotal:   714608 KB
MemFree:      8732 KB
Buffers:     39880 KB
Cached:     172564 KB
VmPeak:     189640 KB
VmSize:     189636 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       37824 KB
VmRSS:       37820 KB
VmData:     111516 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       29400 KB
VmPTE:         192 KB
VmSwap:          0 KB

Threads Information
Threads: 11
PID = 9374 TID = 9374
9374 9512 9513 9515 9516 9517 9518 9519 9520 9521 9522 

Maps Information
ebcb7000 ebcba000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
ece25000 ed624000 rw-p [stack:9522]
ed625000 ee225000 rw-p [stack:9521]
ee226000 eea25000 rw-p [stack:9520]
eea26000 ef225000 rw-p [stack:9519]
efa28000 f0227000 rw-p [stack:9518]
f0228000 f0a27000 rw-p [stack:9517]
f0a27000 f0a2a000 r-xp /usr/lib/gstreamer-0.10/libgstwavenc.so
f0a32000 f0a4c000 r-xp /usr/lib/gstreamer-0.10/libgstpulse.so
f0a55000 f0a8d000 r-xp /usr/lib/libsamrnb.so
f0ab0000 f0abb000 r-xp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
f0ac4000 f0ad4000 r-xp /usr/lib/gstreamer-0.10/libgstalsa.so
f0adc000 f0ae2000 r-xp /usr/lib/libscmn.so
f0aea000 f0b22000 r-xp /usr/lib/libsaac.so
f0b23000 f0b24000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
f0b2c000 f0b31000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencamrnb.so
f0b39000 f0b49000 r-xp /usr/lib/lib_SamsungRec_TizenV04015.so
f0b6a000 f0b72000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
f0b81000 f0b86000 r-xp /usr/lib/gstreamer-0.10/libgstsecrecord.so
f0b98000 f0bb0000 r-xp /usr/lib/libgstcontroller-0.10.so.0.30.0
f0bc0000 f0bc6000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencaac.so
f0bce000 f0be6000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
f0bef000 f0c18000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
f0c2a000 f0c2f000 r-xp /usr/lib/gstreamer-0.10/libgstvolume.so
f0c37000 f0d95000 r-xp /usr/lib/gstreamer-0.10/libgstffmpeg.so
f0e7d000 f0e89000 r-xp /usr/lib/gstreamer-0.10/libgstencodebin.so
f0e91000 f0eb1000 r-xp /usr/lib/gstreamer-0.10/libgstomx.so
f0eb2000 f0ee6000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
f0eef000 f0efa000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
f1001000 f1800000 rw-p [stack:9513]
f1801000 f2000000 rw-p [stack:9512]
f2104000 f2106000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
f210e000 f210f000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
f2117000 f211f000 r-xp /usr/lib/libfeedback.so.0.1.4
f2124000 f2127000 r-xp /usr/lib/gstreamer-0.10/libgstavsysaudiosrc.so
f212f000 f2130000 r-xp /usr/lib/gstreamer-0.10/libgstapp.so
f2138000 f2139000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
f21e9000 f29e8000 rw-p [stack:9515]
f29e8000 f29e9000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
f2b2c000 f332b000 rw-p [stack:9516]
f332b000 f332d000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
f3335000 f334c000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f3359000 f335e000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f3366000 f3371000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f36ab000 f379d000 r-xp /usr/lib/libCOREGL.so.4.0
f37b6000 f37bb000 r-xp /usr/lib/libsystem.so.0.0.0
f37c5000 f37c6000 r-xp /usr/lib/libresponse.so.0.2.96
f37ce000 f37d3000 r-xp /usr/lib/libproc-stat.so.0.2.96
f37dc000 f37de000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f37e6000 f37ed000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f37f6000 f3818000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f3821000 f3825000 r-xp /usr/lib/libogg.so.0.7.1
f382d000 f384f000 r-xp /usr/lib/libvorbis.so.0.4.3
f3857000 f385a000 r-xp /usr/lib/libtinycompress.so.0.0.0
f3862000 f3871000 r-xp /usr/lib/libmdm-common.so.1.1.22
f387a000 f3882000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f388a000 f3890000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f3899000 f38a0000 r-xp /usr/lib/libminizip.so.1.0.0
f38a8000 f38aa000 r-xp /usr/lib/libttrace.so.1.1
f38b2000 f38f9000 r-xp /usr/lib/libsndfile.so.1.0.26
f3905000 f394e000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f3957000 f395c000 r-xp /usr/lib/libjson.so.0.0.1
f51f5000 f52fb000 r-xp /usr/lib/libicuuc.so.57.1
f5311000 f5499000 r-xp /usr/lib/libicui18n.so.57.1
f54a9000 f54b6000 r-xp /usr/lib/libail.so.0.1.0
f54bf000 f54c2000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f54ca000 f54cd000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f54d5000 f5536000 r-xp /usr/lib/libasound.so.2.0.0
f5540000 f5556000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f555e000 f5562000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f556a000 f55ab000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
f55b4000 f55b6000 r-xp /usr/lib/libdri2.so.0.0.0
f55be000 f55c6000 r-xp /usr/lib/libdrm.so.2.4.0
f55ce000 f55d4000 r-xp /usr/lib/libxcb-render.so.0.0.0
f55dc000 f55dd000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f55e6000 f55ea000 r-xp /usr/lib/libEGL.so.1.4
f55fa000 f560b000 r-xp /usr/lib/libGLESv2.so.2.0
f561b000 f5663000 r-xp /usr/lib/libmdm.so.1.2.62
f5664000 f566b000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f5673000 f567e000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f568b000 f56a4000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f56ac000 f56b1000 r-xp /usr/lib/libstorage.so.0.1
f56b9000 f56be000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f56c6000 f56fe000 r-xp /usr/lib/libpulse.so.0.16.2
f56ff000 f5703000 r-xp /usr/lib/libmmfsession.so.0.0.0
f570c000 f5723000 r-xp /usr/lib/libmmfsound.so.0.1.0
f5735000 f5756000 r-xp /usr/lib/libexif.so.12.3.3
f5769000 f5772000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
f577a000 f5787000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
f5790000 f579b000 r-xp /usr/lib/libtbm.so.1.0.0
f57a3000 f57a8000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f57b0000 f5868000 r-xp /usr/lib/libcairo.so.2.11200.14
f5873000 f590e000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
f591a000 f596a000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
f5970000 f5982000 r-xp /usr/lib/libcapi-media-camera.so.0.1.35
f598a000 f59ab000 r-xp /usr/lib/libefl-extension.so.0.1.0
f59b3000 f59b8000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f59c0000 f59c8000 r-xp /usr/lib/libcapi-media-recorder.so.0.1.28
f59d0000 f59d7000 r-xp /opt/usr/apps/org.example.clover/bin/clover
f5b79000 f5b83000 r-xp /lib/libnss_files-2.13.so
f5b8c000 f5c5b000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f5c71000 f5c95000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f5c9e000 f5ca4000 r-xp /usr/lib/libappsvc.so.0.1.0
f5cac000 f5cae000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f5cb7000 f5cbb000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f5cc7000 f5cd2000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f5cda000 f5cdc000 r-xp /usr/lib/libiniparser.so.0
f5ce5000 f5cea000 r-xp /usr/lib/libappcore-common.so.1.1
f5cf2000 f5cf4000 r-xp /usr/lib/libcamsrcjpegenc.so.0.0.0
f5cfc000 f5d00000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f5d0d000 f5d0f000 r-xp /usr/lib/libXau.so.6.0.0
f5d17000 f5d1e000 r-xp /lib/libcrypt-2.13.so
f5d4e000 f5d50000 r-xp /usr/lib/libiri.so
f5d59000 f5f02000 r-xp /usr/lib/libcrypto.so.1.0.0
f5f22000 f5f69000 r-xp /usr/lib/libssl.so.1.0.0
f5f75000 f5fa3000 r-xp /usr/lib/libidn.so.11.5.44
f5fab000 f5fb4000 r-xp /usr/lib/libcares.so.2.1.0
f5fbe000 f5fd1000 r-xp /usr/lib/libxcb.so.1.1.0
f5fda000 f5fdc000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f5fe4000 f5fe6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f5fef000 f60bb000 r-xp /usr/lib/libxml2.so.2.7.8
f60c8000 f60ca000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f60d3000 f60d8000 r-xp /usr/lib/libffi.so.5.0.10
f60e0000 f60e1000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f60e9000 f60ec000 r-xp /lib/libattr.so.1.1.0
f60f4000 f6188000 r-xp /usr/lib/libstdc++.so.6.0.16
f619b000 f61b8000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f61c2000 f61da000 r-xp /usr/lib/libpng12.so.0.50.0
f61e2000 f61f8000 r-xp /lib/libexpat.so.1.6.0
f6202000 f6246000 r-xp /usr/lib/libcurl.so.4.3.0
f624f000 f6259000 r-xp /usr/lib/libXext.so.6.4.0
f6262000 f6266000 r-xp /usr/lib/libXtst.so.6.1.0
f626e000 f6274000 r-xp /usr/lib/libXrender.so.1.3.0
f627c000 f6282000 r-xp /usr/lib/libXrandr.so.2.2.0
f628a000 f628b000 r-xp /usr/lib/libXinerama.so.1.0.0
f6294000 f629d000 r-xp /usr/lib/libXi.so.6.1.0
f62a5000 f62a8000 r-xp /usr/lib/libXfixes.so.3.1.0
f62b0000 f62b2000 r-xp /usr/lib/libXgesture.so.7.0.0
f62ba000 f62bc000 r-xp /usr/lib/libXcomposite.so.1.0.0
f62c4000 f62c6000 r-xp /usr/lib/libXdamage.so.1.1.0
f62ce000 f62d5000 r-xp /usr/lib/libXcursor.so.1.0.2
f62dd000 f62e0000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f62e8000 f62ec000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f62f5000 f62fa000 r-xp /usr/lib/libecore_fb.so.1.7.99
f6303000 f63e4000 r-xp /usr/lib/libX11.so.6.3.0
f63ef000 f6412000 r-xp /usr/lib/libjpeg.so.8.0.2
f642a000 f6440000 r-xp /lib/libz.so.1.2.5
f6448000 f644a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6452000 f64c7000 r-xp /usr/lib/libsqlite3.so.0.8.6
f64d1000 f64eb000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f64f3000 f6527000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6530000 f6603000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f660e000 f661e000 r-xp /lib/libresolv-2.13.so
f6622000 f663a000 r-xp /usr/lib/liblzma.so.5.0.3
f6642000 f6645000 r-xp /lib/libcap.so.2.21
f664d000 f667c000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6684000 f6685000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f668d000 f6693000 r-xp /usr/lib/libecore_imf.so.1.7.99
f669b000 f66b2000 r-xp /usr/lib/liblua-5.1.so
f66bb000 f66c2000 r-xp /usr/lib/libembryo.so.1.7.99
f66ca000 f66d0000 r-xp /lib/librt-2.13.so
f66d9000 f672f000 r-xp /usr/lib/libpixman-1.so.0.28.2
f673c000 f6792000 r-xp /usr/lib/libfreetype.so.6.11.3
f679e000 f67c6000 r-xp /usr/lib/libfontconfig.so.1.8.0
f67c7000 f680c000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6815000 f6828000 r-xp /usr/lib/libfribidi.so.0.3.1
f6830000 f684a000 r-xp /usr/lib/libecore_con.so.1.7.99
f6853000 f685c000 r-xp /usr/lib/libedbus.so.1.7.99
f6864000 f68b4000 r-xp /usr/lib/libecore_x.so.1.7.99
f68b6000 f68bf000 r-xp /usr/lib/libvconf.so.0.2.45
f68c7000 f68d8000 r-xp /usr/lib/libecore_input.so.1.7.99
f68e0000 f68e5000 r-xp /usr/lib/libecore_file.so.1.7.99
f68ed000 f690f000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6918000 f6959000 r-xp /usr/lib/libeina.so.1.7.99
f6962000 f697b000 r-xp /usr/lib/libeet.so.1.7.99
f698c000 f69f5000 r-xp /lib/libm-2.13.so
f69fe000 f6a04000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6a0d000 f6a0e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a16000 f6a39000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a41000 f6a46000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a4e000 f6a78000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a81000 f6a98000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6aa0000 f6aab000 r-xp /lib/libunwind.so.8.0.1
f6ad8000 f6af6000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b00000 f6c24000 r-xp /lib/libc-2.13.so
f6c32000 f6c3a000 r-xp /lib/libgcc_s-4.6.so.1
f6c3b000 f6c3f000 r-xp /usr/lib/libsmack.so.1.0.0
f6c48000 f6c4e000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f6c56000 f6d26000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6d27000 f6d85000 r-xp /usr/lib/libedje.so.1.7.99
f6d8f000 f6da6000 r-xp /usr/lib/libecore.so.1.7.99
f6dbd000 f6e8b000 r-xp /usr/lib/libevas.so.1.7.99
f6eb0000 f6fec000 r-xp /usr/lib/libelementary.so.1.7.99
f7003000 f7017000 r-xp /lib/libpthread-2.13.so
f7022000 f7024000 r-xp /usr/lib/libdlog.so.0.0.0
f702c000 f702f000 r-xp /usr/lib/libbundle.so.0.1.22
f7037000 f7039000 r-xp /lib/libdl-2.13.so
f7042000 f704f000 r-xp /usr/lib/libaul.so.0.1.0
f7060000 f7066000 r-xp /usr/lib/libappcore-efl.so.1.1
f706f000 f7073000 r-xp /usr/lib/libsys-assert.so
f707c000 f7099000 r-xp /lib/ld-2.13.so
f70a2000 f70a7000 r-xp /usr/bin/launchpad-loader
f7549000 f7877000 rw-p [heap]
ffbc6000 ffbe7000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9374)
Call Stack Count: 12
 0: ecore_timer_cb + 0xc9 (0xf59d2562) [/opt/usr/apps/org.example.clover/bin/clover] + 0x2562
 1: (0xf6d9e1f9) [/usr/lib/libecore.so.1] + 0xf1f9
 2: (0xf6d9e2ef) [/usr/lib/libecore.so.1] + 0xf2ef
 3: (0xf6d9b2f3) [/usr/lib/libecore.so.1] + 0xc2f3
 4: ecore_main_loop_begin + 0x30 (0xf6d9b879) [/usr/lib/libecore.so.1] + 0xc879
 5: appcore_efl_main + 0x332 (0xf7063b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
 6: ui_app_main + 0xb0 (0xf5cfe421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 7: uib_app_run + 0xea (0xf59d2ef3) [/opt/usr/apps/org.example.clover/bin/clover] + 0x2ef3
 8: main + 0x34 (0xf59d2489) [/opt/usr/apps/org.example.clover/bin/clover] + 0x2489
 9: (0xf70a3a53) [/opt/usr/apps/org.example.clover/bin/clover] + 0x1a53
10: __libc_start_main + 0x114 (0xf6b1785c) [/lib/libc.so.6] + 0x1785c
11: (0xf70a3e0c) [/opt/usr/apps/org.example.clover/bin/clover] + 0x1e0c
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
in_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:02:04.601+0900 W/W_HOME  ( 2724): event_manager.c: _home_scroll_cb(592) > scroll,done
05-25 17:02:04.601+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:02:04.601+0900 W/W_HOME  ( 2724): clock_manager.c: _compositing_set(205) > hwc:1
05-25 17:02:04.611+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_set_info(1442) > [3769.953408] layer(0x874f48) not usable
05-25 17:02:04.611+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_set_info(1459) > [3769.953442] layer(0x874f48) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
05-25 17:02:04.611+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_layer_set_info(1578) > [3769.953460] layer[0x8749e8]zpos[0]
05-25 17:02:04.621+0900 W/W_HOME  ( 2724): clock_manager.c: _hwc_enabled_success_cb(153) > hwc enabled
05-25 17:02:04.791+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:02:04.821+0900 W/KEYROUTER( 2318): e_mod_main.c: DeliverDeviceKeyEvents(3237) > Deliver KeyPress to focus window. value=1997, window=0x1e00003
05-25 17:02:04.821+0900 W/KEYROUTER( 2318): e_mod_main.c: DeliverDeviceKeyEvents(3248) > Deliver KeyPress as shared grab. value=1997, window=0x1800002
05-25 17:02:04.821+0900 W/STARTER ( 2650): hw_key.c: _key_press_cb(1443) > [_key_press_cb:1443] POWER Key is pressed
05-25 17:02:04.821+0900 W/STARTER ( 2650): hw_key.c: _key_press_cb(1446) > [_key_press_cb:1446] LCD state : 1
05-25 17:02:04.821+0900 W/STARTER ( 2650): hw_key.c: _key_press_cb(1453) > [_key_press_cb:1453] PM state : 1
05-25 17:02:04.821+0900 E/STARTER ( 2650): hw_key.c: _key_press_cb(1459) > [_key_press_cb:1459] Failed to get VCONFKEY_SIMPLECLOCK_UI_STATUS
05-25 17:02:04.821+0900 W/STARTER ( 2650): hw_key.c: _key_press_cb(1462) > [_key_press_cb:1462] Simple Clock state : 0
05-25 17:02:04.821+0900 W/STARTER ( 2650): hw_key.c: _key_press_cb(1467) > [_key_press_cb:1467] powerkey count : 1
05-25 17:02:04.821+0900 E/EFL     ( 2724): ecore_x<2724> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=3770164
05-25 17:02:04.821+0900 W/W_HOME  ( 2724): main.c: _direct_home_key_cb(1447) > was_win_on_top:1
05-25 17:02:04.981+0900 W/KEYROUTER( 2318): e_mod_main.c: DeliverDeviceKeyEvents(3275) > Deliver KeyRelease. value=1997, window=0x1800002
05-25 17:02:04.981+0900 W/KEYROUTER( 2318): e_mod_main.c: DeliverDeviceKeyEvents(3275) > Deliver KeyRelease. value=1997, window=0x1e00003
05-25 17:02:04.981+0900 W/STARTER ( 2650): hw_key.c: _key_release_cb(1340) > [_key_release_cb:1340] POWER Key is released
05-25 17:02:04.981+0900 E/EFL     ( 2724): ecore_x<2724> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=3770327
05-25 17:02:04.991+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:02:04.991+0900 W/W_HOME  ( 2724): index.c: index_hide(337) > hide VI:1 visibility:0 vi:(nil)
05-25 17:02:05.181+0900 W/AUL_AMD ( 2490): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-25 17:02:05.181+0900 W/AUL_AMD ( 2490): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
05-25 17:02:05.191+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:02:05.241+0900 W/STARTER ( 2650): hw_key.c: _powerkey_timer_cb(922) > [_powerkey_timer_cb:922] _powerkey_timer_cb, powerkey count[1]
05-25 17:02:05.241+0900 W/STARTER ( 2650): hw_key.c: _powerkey_timer_cb(1132) > [_powerkey_timer_cb:1132] clock visibility[1] pressed lcd status[1], current lcd status[1] pressed pm state[1]
05-25 17:02:05.241+0900 E/STARTER ( 2650): dbus-util.c: dbus_request_cpu_boost(292) > [dbus_request_cpu_boost:292] failed to _invoke_dbus_method_sync
05-25 17:02:05.241+0900 W/AUL     ( 2650): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-home)
05-25 17:02:05.241+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 0
05-25 17:02:05.241+0900 W/AUL_AMD ( 2490): amd_launch.c: _start_app(1782) > caller pid : 2650
05-25 17:02:05.241+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_resume_request_signal(567) > aul_send_app_resume_request_signal app(com.samsung.w-home) pid(2724) type(uiapp) bg(0)
05-25 17:02:05.241+0900 W/AUL_AMD ( 2490): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 2724
05-25 17:02:05.251+0900 I/APP_CORE( 2724): appcore-efl.c: __do_app(453) > [APP 2724] Event: RESET State: RUNNING
05-25 17:02:05.251+0900 I/CAPI_APPFW_APPLICATION( 2724): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-25 17:02:05.251+0900 W/CAPI_APPFW_APP_CONTROL( 2724): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
05-25 17:02:05.251+0900 W/W_HOME  ( 2724): main.c: _app_control_progress(1571) > Service value : powerkey
05-25 17:02:05.251+0900 W/wnotib  ( 2724): w-notification-board-broker-main.c: _wnotib_view_event_handler(1308) > Home view event: 0x40001
05-25 17:02:05.251+0900 E/wnotib  ( 2724): w-notification-board-action.c: wnb_action_is_popup_shown(4738) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-25 17:02:05.251+0900 E/wnotib  ( 2724): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-25 17:02:05.251+0900 W/wnotib  ( 2724): w-notification-board-broker-main.c: wnotib_main_dismiss_confirmation_popup(1427) > 
05-25 17:02:05.251+0900 W/W_HOME  ( 2724): noti_broker.c: _noti_broker_home_cb(779) > continue the home key execution
05-25 17:02:05.251+0900 E/W_HOME  ( 2724): cs_broker.c: _cs_broker_home_cb(274) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
05-25 17:02:05.251+0900 W/AUL_AMD ( 2490): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(2724), cmd(0)
05-25 17:02:05.251+0900 E/AUL     ( 2490): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
05-25 17:02:05.251+0900 W/AUL     ( 2650): launch.c: app_request_to_launchpad(298) > request cmd(0) result(2724)
05-25 17:02:05.251+0900 W/STARTER ( 2650): pkg-monitor.c: _app_mgr_status_cb(415) > [_app_mgr_status_cb:415] Resume request [2724]
05-25 17:02:05.251+0900 W/W_HOME  ( 2724): main.c: _home_key_cb(1469) > Home Key operation tutorial:0 window:1 clock:1 apps:0 is_app_resumed:1
05-25 17:02:05.251+0900 W/W_HOME  ( 2724): move.c: move_move_to_apps(216) > move to apps
05-25 17:02:05.251+0900 W/W_HOME  ( 2724): rotary.c: rotary_attach(138) > rotary_attach:0xf808f958
05-25 17:02:05.251+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf808f958, elm_layout, _activated_obj : 0xf7e6e620, activated : 1
05-25 17:02:05.251+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-25 17:02:05.251+0900 W/W_HOME  ( 2724): event_manager.c: _move_module_anim_start_cb(673) > state: 0 -> 1
05-25 17:02:05.251+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:02:05.251+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:02:05.251+0900 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
05-25 17:02:05.251+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
05-25 17:02:05.251+0900 W/APPS    ( 2724): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
05-25 17:02:05.261+0900 E/AUL     ( 2650): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
05-25 17:02:05.271+0900 I/APP_CORE( 2724): appcore-efl.c: __do_app(529) > Legacy lifecycle: 1
05-25 17:02:05.271+0900 W/W_HOME  ( 2724): event_manager.c: _apptray_visibility_cb(611) > apps,show,start
05-25 17:02:05.271+0900 W/W_HOME  ( 2724): event_manager.c: _apptray_visibility_cb(631) > state: 1 -> 0
05-25 17:02:05.271+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:02:05.271+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:02:05.271+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:02:05.271+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:02:05.271+0900 W/W_HOME  ( 2724): clock_manager.c: _compositing_set(205) > hwc:0
05-25 17:02:05.271+0900 W/W_HOME  ( 2724): noti_broker.c: _apptray_visibility_cb(786) > apps,show,start
05-25 17:02:05.271+0900 W/W_HOME  ( 2724): noti_broker.c: noti_broker_event_fire_to_plugin(1003) > source:1 event:80002
05-25 17:02:05.271+0900 W/wnotib  ( 2724): w-notification-board-broker-main.c: _wnotib_view_event_handler(1308) > Home view event: 0x80002
05-25 17:02:05.271+0900 I/wnotib  ( 2724): w-notification-board-broker-main.c: _wnotib_view_event_handler(1418) > Unhandled type: 0x80002
05-25 17:02:05.271+0900 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
05-25 17:02:05.271+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
05-25 17:02:05.321+0900 W/W_HOME  ( 2724): clock_manager.c: _hwc_disabled_timer_cb(125) > hwc disabled
05-25 17:02:05.321+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_unset_buffer(1602) > [3770.669046] layer(0x874f48) now usable
05-25 17:02:05.321+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [3770.669072] layer[0x8749e8]zpos[0]
05-25 17:02:05.391+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:02:05.541+0900 W/W_HOME  ( 2724): event_manager.c: _move_module_anim_end_cb(687) > state: 1 -> 0
05-25 17:02:05.541+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:02:05.541+0900 W/W_HOME  ( 2724): rotary.c: rotary_deattach(156) > rotary_deattach:0xf808f958
05-25 17:02:05.541+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-25 17:02:05.541+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xf808f958, elm_layout, func : 0xf75344fd
05-25 17:02:05.541+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-25 17:02:05.541+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-25 17:02:05.541+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-25 17:02:05.541+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf7e6e620, elm_box, _activated_obj : 0xf808f958, activated : 1
05-25 17:02:05.541+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-25 17:02:05.541+0900 E/wnotib  ( 2724): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-25 17:02:05.541+0900 I/wnotib  ( 2724): w-notification-board-basic-panel.c: _wnb_basic_panel_passed_key_event_allow(6237) > Return true for 4, 101.
05-25 17:02:05.541+0900 I/wnotib  ( 2724): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1225) > No second depth view available.
05-25 17:02:05.541+0900 W/W_HOME  ( 2724): event_manager.c: _apptray_visibility_cb(611) > apps,show
05-25 17:02:05.541+0900 W/W_HOME  ( 2724): event_manager.c: _apptray_visibility_cb(631) > state: 1 -> 1
05-25 17:02:05.541+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-25 17:02:05.541+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-25 17:02:05.541+0900 W/W_HOME  ( 2724): main.c: home_pause(547) > clock/widget paused
05-25 17:02:05.541+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-25 17:02:05.541+0900 W/APPS    ( 2724): apps_main.c: _time_changed_cb(308) >  date : 25->25
05-25 17:02:05.541+0900 W/APPS    ( 2724): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
05-25 17:02:05.541+0900 W/W_HOME  ( 2724): rotary.c: rotary_attach(138) > rotary_attach:0xf7f28ac0
05-25 17:02:05.541+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf7f28ac0, elm_layout, _activated_obj : 0xf7e6e620, activated : 1
05-25 17:02:05.541+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-25 17:02:05.541+0900 W/W_HOME  ( 2724): win.c: win_back_gesture_disable_set(170) > disable back gesture
05-25 17:02:05.541+0900 W/W_HOME  ( 2724): win.c: win_back_gesture_disable_set(170) > disable back gesture
05-25 17:02:05.541+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-25 17:02:05.541+0900 W/W_HOME  ( 2724): noti_broker.c: _apptray_visibility_cb(786) > apps,show
05-25 17:02:05.541+0900 W/W_HOME  ( 2724): noti_broker.c: noti_broker_event_fire_to_plugin(1003) > source:1 event:80000
05-25 17:02:05.541+0900 W/wnotib  ( 2724): w-notification-board-broker-main.c: _wnotib_view_event_handler(1308) > Home view event: 0x80000
05-25 17:02:05.541+0900 E/wnotib  ( 2724): w-notification-board-action.c: wnb_action_is_event_receivable(5108) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-25 17:02:05.541+0900 I/wnotib  ( 2724): w-notification-board-basic-panel.c: _wnb_basic_panel_close_second_depth_view(6316) > wnotib_action_drawer_is_event_receivable: 0, third_depth_genlist: (nil), _wnotib_basic_panel_is_third_depth_thread_view: 0, wnotib_common_is_toast_popup_displayed: 0
05-25 17:02:05.541+0900 E/wnotib  ( 2724): w-notification-board-action.c: wnb_action_is_event_receivable(5108) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-25 17:02:05.541+0900 I/wnotib  ( 2724): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed_cb(1030) > is_app_tray_displayed: 1
05-25 17:02:05.541+0900 W/wnotib  ( 2724): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [3], notiboard card appending count [8].
05-25 17:02:05.541+0900 E/APPS    ( 2724): apps_main.c: apps_main_resume(1003) >  resumed already
05-25 17:02:05.551+0900 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
05-25 17:02:05.551+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
05-25 17:02:05.561+0900 W/WATCH_CORE( 2779): appcore-watch.c: __widget_pause(1113) > widget_pause
05-25 17:02:05.561+0900 W/AUL     ( 2779): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.chronograph16) pid(2779) status(bg) type(watchapp)
05-25 17:02:05.561+0900 D/chronograph( 2779): ChronographApp.cpp: _appPause(150) > [0;34m>>>HIT<<<[0;m
05-25 17:02:05.561+0900 W/chronograph( 2779): ChronographViewController.cpp: onPause(183) > [0;35mState is Pause[isPaused=1], StopwatchState=0[0;m
05-25 17:02:05.561+0900 W/chronograph( 2779): ChronographSweepSecond.cpp: resetSweepSecond(103) > [0;35mresetSweepSecond >>>>[0;m
05-25 17:02:05.561+0900 D/chronograph( 2779): ChronographSweepSecond.cpp: resetSweepSecond(107) > Stop and Clear sweepAnimation !!
05-25 17:02:05.561+0900 D/chronograph-common( 2779): ChronographSensor.cpp: disableAcceleormeter(52) > [0;32mBEGIN >>>>[0;m
05-25 17:02:05.561+0900 D/chronograph-common( 2779): ChronographSensor.cpp: _stopAccelerometer(129) > [0;32mBEGIN >>>>[0;m
05-25 17:02:06.251+0900 W/AUL_AMD ( 2490): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-25 17:02:06.251+0900 W/AUL_AMD ( 2490): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
05-25 17:02:06.331+0900 E/EFL     ( 2724): ecore_x<2724> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=3771669 button=1
05-25 17:02:06.331+0900 W/APPS    ( 2724): AppsViewNecklace.cpp: touchPressed(1639) >  TOUCH [76, 275]
05-25 17:02:06.411+0900 E/EFL     ( 2724): ecore_x<2724> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=3771756 button=1
05-25 17:02:06.411+0900 W/APPS    ( 2724): AppsViewNecklace.cpp: touchReleased(1952) >  TOUCH [76, 275]->[81, 269]
05-25 17:02:06.411+0900 W/APPS    ( 2724): AppsViewNecklace.cpp: runFocusAni(3467) >  nNewFocus[21], anim[1], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[23]
05-25 17:02:06.421+0900 W/APPS    ( 2724): AppsItem.cpp: onItemClicked(463) >  onItemClicked[0,21]
05-25 17:02:06.421+0900 E/APPS    ( 2724): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
05-25 17:02:06.421+0900 W/APPS    ( 2724): AppsItem.cpp: onItemClicked(487) >  item(clover) launched, open(0), tts(0)
05-25 17:02:06.421+0900 W/AUL     ( 2724): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.clover)
05-25 17:02:06.421+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 0
05-25 17:02:06.421+0900 W/AUL_AMD ( 2490): amd_launch.c: _start_app(1782) > caller pid : 2724
05-25 17:02:06.421+0900 I/AUL_AMD ( 2490): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
05-25 17:02:06.441+0900 E/RESOURCED( 2613): block.c: block_prelaunch_state(138) > insert data org.example.clover, table num : 3
05-25 17:02:06.441+0900 W/AUL_AMD ( 2490): amd_launch.c: _start_app(2218) > pad pid(-5)
05-25 17:02:06.441+0900 W/AUL_PAD ( 3264): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
05-25 17:02:06.441+0900 W/AUL_PAD ( 3264): launchpad.c: __send_result_to_caller(272) > Check app launching
05-25 17:02:06.441+0900 W/AUL_PAD ( 9374): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
05-25 17:02:06.441+0900 W/AUL_PAD ( 9374): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
05-25 17:02:06.441+0900 W/AUL_PAD ( 9374): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
05-25 17:02:06.441+0900 W/AUL_PAD ( 9374): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.clover)
05-25 17:02:06.491+0900 I/efl-extension( 9374): efl_extension.c: eext_mod_init(40) > Init
05-25 17:02:06.491+0900 W/AUL_PAD ( 9374): launchpad_loader.c: main(690) > [candidate] dlsym
05-25 17:02:06.491+0900 W/AUL_PAD ( 9374): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.clover)
05-25 17:02:06.491+0900 I/CAPI_APPFW_APPLICATION( 9374): app_main.c: ui_app_main(704) > app_efl_main
05-25 17:02:06.491+0900 I/CAPI_APPFW_APPLICATION( 9374): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-25 17:02:06.541+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.clover) pid(9374) type(uiapp) bg(0)
05-25 17:02:06.541+0900 W/AUL_AMD ( 2490): amd_status.c: __socket_monitor_cb(1277) > (9374) was created
05-25 17:02:06.541+0900 E/AUL     ( 2490): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
05-25 17:02:06.541+0900 W/AUL     ( 2724): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9374)
05-25 17:02:06.541+0900 W/W_HOME  ( 2724): util.c: apps_util_launch_main_operation(643) > Launch app:[clover] ret:[0]
05-25 17:02:06.551+0900 W/STARTER ( 2650): pkg-monitor.c: _app_mgr_status_cb(394) > [_app_mgr_status_cb:394] Launch request [9374]
05-25 17:02:06.591+0900 E/EFL     ( 9374): ecore_evas<9374> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-25 17:02:06.601+0900 W/W_HOME  ( 2724): event_manager.c: _ecore_x_message_cb(428) > state: 0 -> 1
05-25 17:02:06.601+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-25 17:02:06.601+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-25 17:02:06.601+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-25 17:02:06.601+0900 W/W_HOME  ( 2724): win.c: win_back_gesture_disable_set(173) > enable back gesture
05-25 17:02:06.601+0900 W/W_HOME  ( 2724): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 0
05-25 17:02:06.601+0900 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
05-25 17:02:06.601+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
05-25 17:02:06.651+0900 E/EFL     ( 9374): elementary<9374> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
05-25 17:02:06.661+0900 E/EFL     ( 9374): elementary<9374> elc_naviframe.c:2950 elm_naviframe_item_push() item(0xf76ad670) will be pushed
05-25 17:02:06.691+0900 E/TIZEN_N_RECORDER( 9374): recorder.c: __convert_recorder_error_code(193) > [audio-channel] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:02:06.691+0900 E/TIZEN_N_RECORDER( 9374): recorder.c: __convert_recorder_error_code(193) > [audio-device] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:02:06.701+0900 I/APP_CORE( 9374): appcore-efl.c: __do_app(453) > [APP 9374] Event: RESET State: CREATED
05-25 17:02:06.701+0900 I/CAPI_APPFW_APPLICATION( 9374): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-25 17:02:06.711+0900 I/APP_CORE( 9374): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
05-25 17:02:06.711+0900 I/APP_CORE( 9374): appcore-efl.c: __do_app(524) > [APP 9374] Initial Launching, call the resume_cb
05-25 17:02:06.711+0900 I/CAPI_APPFW_APPLICATION( 9374): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-25 17:02:06.711+0900 W/APP_CORE( 9374): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3600002
05-25 17:02:06.761+0900 W/W_HOME  ( 2724): event_manager.c: _window_visibility_cb(473) > Window [0x1E00003] is now visible(1)
05-25 17:02:06.761+0900 W/W_HOME  ( 2724): event_manager.c: _window_visibility_cb(483) > state: 1 -> 0
05-25 17:02:06.761+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-25 17:02:06.761+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-25 17:02:06.761+0900 W/W_HOME  ( 2724): main.c: _window_visibility_cb(964) > Window [0x1E00003] is now visible(1)
05-25 17:02:06.761+0900 I/APP_CORE( 9374): appcore-efl.c: __do_app(453) > [APP 9374] Event: RESUME State: RUNNING
05-25 17:02:06.771+0900 I/APP_CORE( 2724): appcore-efl.c: __do_app(453) > [APP 2724] Event: PAUSE State: RUNNING
05-25 17:02:06.771+0900 I/CAPI_APPFW_APPLICATION( 2724): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-25 17:02:06.771+0900 W/W_HOME  ( 2724): main.c: _appcore_pause_cb(488) > appcore pause
05-25 17:02:06.771+0900 W/W_HOME  ( 2724): event_manager.c: _app_pause_cb(397) > state: 1 -> 2
05-25 17:02:06.771+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-25 17:02:06.771+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2724) status(bg) type(uiapp)
05-25 17:02:06.771+0900 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2724] goes to (4)
05-25 17:02:06.771+0900 E/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2724)'s state(4)
05-25 17:02:06.771+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-25 17:02:06.771+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-25 17:02:06.771+0900 W/W_HOME  ( 2724): rotary.c: rotary_deattach(156) > rotary_deattach:0xf7f28ac0
05-25 17:02:06.771+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-25 17:02:06.771+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xf7f28ac0, elm_layout, func : 0xf75344fd
05-25 17:02:06.771+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-25 17:02:06.771+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-25 17:02:06.771+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-25 17:02:06.771+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf7e6e620, elm_box, _activated_obj : 0xf7f28ac0, activated : 1
05-25 17:02:06.771+0900 I/efl-extension( 2724): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-25 17:02:06.771+0900 E/wnotib  ( 2724): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-25 17:02:06.771+0900 I/wnotib  ( 2724): w-notification-board-basic-panel.c: _wnb_basic_panel_passed_key_event_allow(6237) > Return true for 4, 101.
05-25 17:02:06.771+0900 I/wnotib  ( 2724): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1225) > No second depth view available.
05-25 17:02:06.781+0900 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
05-25 17:02:06.781+0900 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[9374] goes to (3)
05-25 17:02:06.781+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.clover) pid(9374) status(fg) type(uiapp)
05-25 17:02:06.791+0900 W/APPS    ( 2724): AppsItem.cpp: setLastIndex(1264) >  This is last index app [22:WDS_AT_OPT_GET_MORE_APPS_ABB], focusIdx[21]
05-25 17:02:06.791+0900 W/APPS    ( 2724): AppsViewNecklace.cpp: __onSignalHideNextPage(7029) >  Hide next page [0->0]
05-25 17:02:06.791+0900 W/APPS    ( 2724): AppsItem.cpp: aniFocusIndex(2351) >  [clover:21] Focused[1], focusIdx[21]
05-25 17:02:06.791+0900 W/W_HOME  ( 2724): win.c: win_back_gesture_disable_set(173) > enable back gesture
05-25 17:02:06.791+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-25 17:02:06.791+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-25 17:02:06.791+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-25 17:02:06.791+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-25 17:02:06.791+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-25 17:02:06.791+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-25 17:02:06.791+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-25 17:02:06.791+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:02:06.801+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-25 17:02:06.801+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-25 17:02:06.801+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-25 17:02:06.801+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-25 17:02:06.801+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
05-25 17:02:06.801+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-25 17:02:06.801+0900 I/MESSAGE_PORT( 2485): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-25 17:02:06.801+0900 I/MESSAGE_PORT( 2485): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-25 17:02:06.801+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-25 17:02:06.801+0900 I/MESSAGE_PORT( 2485): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-25 17:02:06.801+0900 E/CAPI_APPFW_APP_CONTROL( 2895): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-25 17:02:06.801+0900 W/MUSIC_CONTROL_SERVICE( 2895): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:2895]   [com.samsung.w-home]register msg port [false][0m
05-25 17:02:06.801+0900 I/wnotib  ( 2724): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
05-25 17:02:06.801+0900 E/wnotib  ( 2724): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-25 17:02:06.801+0900 W/wnotib  ( 2724): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [3], notiboard card appending count [8].
05-25 17:02:06.811+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
05-25 17:02:06.821+0900 W/APPS    ( 2724): AppsViewNecklace.cpp: onPausedIdlerCb(5156) >  elm_cache_all_flush
05-25 17:02:07.171+0900 E/AUL     ( 2490): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
05-25 17:02:07.311+0900 I/APP_CORE( 2724): appcore-efl.c: __do_app(453) > [APP 2724] Event: MEM_FLUSH State: PAUSED
05-25 17:02:07.641+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 14
05-25 17:02:07.651+0900 W/AUL_AMD ( 2490): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9374
05-25 17:02:07.651+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 12
05-25 17:02:07.671+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 14
05-25 17:02:07.681+0900 W/AUL_AMD ( 2490): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9374
05-25 17:02:07.681+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 12
05-25 17:02:07.871+0900 I/AUL_PAD ( 9514): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
05-25 17:02:08.921+0900 E/EFL     ( 9374): ecore_x<9374> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=3774262 button=1
05-25 17:02:08.981+0900 E/EFL     ( 9374): ecore_x<9374> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=3774323 button=1
05-25 17:02:09.061+0900 I/USR_TAG ( 9374): record_start
05-25 17:02:09.061+0900 E/TIZEN_N_RECORDER( 9374): recorder.c: __convert_recorder_error_code(193) > [recorder_attr_set_time_limit] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:02:09.061+0900 E/TIZEN_N_RECORDER( 9374): recorder.c: __convert_recorder_error_code(193) > [recorder_set_filename] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:02:09.061+0900 E/TIZEN_N_RECORDER( 9374): recorder.c: __convert_recorder_error_code(193) > [file-format] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:02:09.061+0900 E/TIZEN_N_RECORDER( 9374): recorder.c: __convert_recorder_error_code(193) > [audio-encoder] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:02:09.381+0900 E/TIZEN_N_RECORDER( 9374): recorder.c: __convert_recorder_error_code(193) > [recorder_start] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:02:09.381+0900 E/EFL     ( 9374): <9374> elm_main.c:1300 elm_object_disabled_set() safety check failed: obj == NULL
05-25 17:02:09.381+0900 E/EFL     ( 9374): <9374> elm_main.c:1300 elm_object_disabled_set() safety check failed: obj == NULL
05-25 17:02:09.401+0900 E/EFL     ( 9374): elementary<9374> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
05-25 17:02:09.411+0900 E/EFL     ( 9374): elementary<9374> elc_naviframe.c:2950 elm_naviframe_item_push() item(0xf200d760) will be pushed
05-25 17:02:09.421+0900 E/EFL     ( 9374): elementary<9374> elc_naviframe.c:2796 _push_transition_cb() item(0xf200d760) will transition
05-25 17:02:09.861+0900 E/EFL     ( 9374): elementary<9374> elc_naviframe.c:1193 _on_item_push_finished() item(0xf76ad670) transition finished
05-25 17:02:09.861+0900 E/EFL     ( 9374): elementary<9374> elc_naviframe.c:1218 _on_item_show_finished() item(0xf200d760) transition finished
05-25 17:02:09.981+0900 E/EFL     ( 2318): ecore_x<2318> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x3600002 time=3774760
05-25 17:02:09.981+0900 E/EFL     ( 9374): ecore_x<9374> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=3774760
05-25 17:02:09.981+0900 E/EFL     ( 2318): ecore_x<2318> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=3774760
05-25 17:02:11.811+0900 I/APP_CORE( 2724): appcore-efl.c: __do_app(453) > [APP 2724] Event: MEM_FLUSH State: PAUSED
05-25 17:02:23.451+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_unset_buffer(1602) > [3788.791904] layer(0x874fb8) now usable
05-25 17:02:23.451+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [3788.791968] layer[0x874b08]zpos[1]
05-25 17:02:23.451+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_unset_buffer(1602) > [3788.792026] layer(0x875008) now usable
05-25 17:02:23.451+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [3788.792047] layer[0x874c28]zpos[2]
05-25 17:02:23.451+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [3788.792075] dpms[0 -> 3]sync[1]
05-25 17:02:23.451+0900 I/TDM     ( 1552): 
05-25 17:02:23.491+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -147223796[0;m
05-25 17:02:23.491+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
05-25 17:02:23.491+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
05-25 17:02:23.491+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
05-25 17:02:23.491+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
05-25 17:02:23.501+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
05-25 17:02:23.501+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
05-25 17:02:23.501+0900 W/WATCH_CORE( 2779): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
05-25 17:02:23.501+0900 W/W_HOME  ( 2724): dbus.c: _dbus_message_recv_cb(204) > LCD off
05-25 17:02:23.501+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
05-25 17:02:23.501+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_disable_timer_del(157) > timer del
05-25 17:02:23.501+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_enable(138) > 1
05-25 17:02:23.501+0900 W/W_HOME  ( 2724): event_manager.c: _lcd_off_cb(736) > lcd state: 0
05-25 17:02:23.501+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-25 17:02:23.501+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
05-25 17:02:23.501+0900 W/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-25 17:02:23.501+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
05-25 17:02:23.501+0900 I/HIGEAR  ( 3216): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
05-25 17:02:23.501+0900 W/STARTER ( 2650): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [timeout]
05-25 17:02:23.501+0900 W/STARTER ( 2650): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
05-25 17:02:23.511+0900 E/STARTER ( 2650): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
05-25 17:02:23.511+0900 W/STARTER ( 2650): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
05-25 17:02:23.511+0900 W/STARTER ( 2650): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
05-25 17:02:23.591+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [3788.931325] dpms[3 -> 3]done
05-25 17:02:23.591+0900 I/TDM     ( 1552): 
05-25 17:02:23.601+0900 W/SHealthCommon( 3233): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:3[0;m
05-25 17:02:23.601+0900 W/SHealthService( 3233): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-25 17:02:23.601+0900 W/SHealthCommon( 2843): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:3[0;m
05-25 17:02:23.601+0900 W/W_INDICATOR( 2651): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1504) > [windicator_hide_moment_bar_directly:1504] windicator_hide_moment_bar_directly
05-25 17:02:23.621+0900 W/STARTER ( 2650): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [timeout]
05-25 17:02:23.621+0900 W/STARTER ( 2650): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[0]
05-25 17:02:23.621+0900 W/STARTER ( 2650): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
05-25 17:02:23.621+0900 W/STARTER ( 2650): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[0]
05-25 17:02:23.621+0900 E/ALARM_MANAGER( 2650): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(20), start(25-5-2017, 17:02:44), repeat(1), interval(20), type(-1073741822)
05-25 17:02:23.631+0900 W/W_INDICATOR( 2651): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
05-25 17:02:23.631+0900 W/W_INDICATOR( 2651): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
05-25 17:02:23.631+0900 W/W_INDICATOR( 2651): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1504) > [windicator_hide_moment_bar_directly:1504] windicator_hide_moment_bar_directly
05-25 17:02:23.631+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2650].
05-25 17:02:23.631+0900 I/APP_CORE( 9374): appcore-efl.c: __do_app(453) > [APP 9374] Event: PAUSE State: RUNNING
05-25 17:02:23.631+0900 I/CAPI_APPFW_APPLICATION( 9374): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-25 17:02:23.641+0900 W/APP_CORE( 9374): appcore-efl.c: _capture_and_make_file(1721) > Capture : win[3600002] -> redirected win[604120] for org.example.clover[9374]
05-25 17:02:23.681+0900 E/ALARM_MANAGER( 2443): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 225288255, next duetime: 1495699364
05-25 17:02:23.681+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(225288255)
05-25 17:02:23.681+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1495699828), due_time(1495699364)
05-25 17:02:23.691+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
05-25 17:02:23.691+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-25 17:02:23.691+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 25-5-2017, 08:02:44 (UTC).
05-25 17:02:23.691+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-25 17:02:23.701+0900 E/ALARM_MANAGER( 2443): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
05-25 17:02:27.381+0900 I/USR_TAG ( 9374): loud sound is detected!
05-25 17:02:27.731+0900 W/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
05-25 17:02:27.731+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
05-25 17:02:27.731+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:02:27.731+0900 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2724] goes to (3)
05-25 17:02:27.731+0900 E/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2724)'s state(3)
05-25 17:02:27.731+0900 W/AUL_AMD ( 2490): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-25 17:02:27.731+0900 W/AUL_AMD ( 2490): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
05-25 17:02:27.731+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2724) status(fg) type(uiapp)
05-25 17:02:27.771+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 9374 pgid = 9374
05-25 17:02:27.771+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
05-25 17:02:27.811+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
05-25 17:02:27.811+0900 I/AUL_AMD ( 2490): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 9374
05-25 17:02:27.811+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(9374)
05-25 17:02:27.871+0900 W/CRASH_MANAGER( 9532): worker.c: worker_job(1199) > 1109374636c6f149569934

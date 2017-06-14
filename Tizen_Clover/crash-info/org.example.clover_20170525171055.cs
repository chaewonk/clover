S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.1
Build-Number: R760XXU1APL2
Build-Date: 2016.12.20 22:57:01

Crash Information
Process Name: clover
PID: 10616
Date: 2017-05-25 17:10:55+0900
Executable File Path: /opt/usr/apps/org.example.clover/bin/clover
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 10616, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0xf5e142b0, r3   = 0x00000001
r4   = 0xf71dc9b8, r5   = 0xf71dc9b8
r6   = 0xf71dc16c, r7   = 0xffee9490
r8   = 0xf71dc9b8, r9   = 0xf7a1db80
r10  = 0xf71eab10, fp   = 0x00000000
ip   = 0xf5e142f0, sp   = 0xffee9440
lr   = 0xf6fa05d0, pc   = 0xf5e00562
cpsr = 0x60000030

Memory Information
MemTotal:   714608 KB
MemFree:      9852 KB
Buffers:     32560 KB
Cached:     173032 KB
VmPeak:     189056 KB
VmSize:     189052 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       37136 KB
VmRSS:       37132 KB
VmData:     111012 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       29384 KB
VmPTE:         180 KB
VmSwap:          0 KB

Threads Information
Threads: 11
PID = 10616 TID = 10616
10616 10696 10697 10706 10707 10708 10709 10710 10711 10712 10713 

Maps Information
ed255000 eda54000 rw-p [stack:10713]
eda55000 ee655000 rw-p [stack:10712]
ee656000 eee55000 rw-p [stack:10711]
eee56000 ef655000 rw-p [stack:10710]
efe58000 f0657000 rw-p [stack:10709]
f0658000 f0e57000 rw-p [stack:10708]
f0e57000 f0e5a000 r-xp /usr/lib/gstreamer-0.10/libgstwavenc.so
f0e62000 f0e7c000 r-xp /usr/lib/gstreamer-0.10/libgstpulse.so
f0e85000 f0ebd000 r-xp /usr/lib/libsamrnb.so
f0ee0000 f0eeb000 r-xp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
f0ef4000 f0f04000 r-xp /usr/lib/gstreamer-0.10/libgstalsa.so
f0f0c000 f0f12000 r-xp /usr/lib/libscmn.so
f0f1a000 f0f52000 r-xp /usr/lib/libsaac.so
f0f5c000 f0f61000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencamrnb.so
f0f69000 f0f79000 r-xp /usr/lib/lib_SamsungRec_TizenV04015.so
f0f9a000 f0fa2000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
f0fb1000 f0fb6000 r-xp /usr/lib/gstreamer-0.10/libgstsecrecord.so
f0fc8000 f0fe0000 r-xp /usr/lib/libgstcontroller-0.10.so.0.30.0
f0ff0000 f0ff6000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencaac.so
f0ffe000 f1016000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
f101f000 f1048000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
f105a000 f105f000 r-xp /usr/lib/gstreamer-0.10/libgstvolume.so
f1067000 f11c5000 r-xp /usr/lib/gstreamer-0.10/libgstffmpeg.so
f12ad000 f12b9000 r-xp /usr/lib/gstreamer-0.10/libgstencodebin.so
f12c1000 f12e1000 r-xp /usr/lib/gstreamer-0.10/libgstomx.so
f12e2000 f1316000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
f131f000 f132a000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
f1332000 f1334000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
f133c000 f133d000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
f1347000 f134a000 r-xp /usr/lib/gstreamer-0.10/libgstavsysaudiosrc.so
f1352000 f1353000 r-xp /usr/lib/gstreamer-0.10/libgstapp.so
f145a000 f1c59000 rw-p [stack:10697]
f1c5a000 f2459000 rw-p [stack:10696]
f2602000 f260a000 r-xp /usr/lib/libfeedback.so.0.1.4
f260d000 f260e000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
f2617000 f2e16000 rw-p [stack:10706]
f2e16000 f2e17000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
f2f5a000 f3759000 rw-p [stack:10707]
f3759000 f375b000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
f3763000 f377a000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f3787000 f378c000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f3794000 f379f000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f3ad9000 f3bcb000 r-xp /usr/lib/libCOREGL.so.4.0
f3be4000 f3be9000 r-xp /usr/lib/libsystem.so.0.0.0
f3bf3000 f3bf4000 r-xp /usr/lib/libresponse.so.0.2.96
f3bfc000 f3c01000 r-xp /usr/lib/libproc-stat.so.0.2.96
f3c0a000 f3c0c000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f3c14000 f3c1b000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f3c24000 f3c46000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f3c4f000 f3c53000 r-xp /usr/lib/libogg.so.0.7.1
f3c5b000 f3c7d000 r-xp /usr/lib/libvorbis.so.0.4.3
f3c85000 f3c88000 r-xp /usr/lib/libtinycompress.so.0.0.0
f3c90000 f3c9f000 r-xp /usr/lib/libmdm-common.so.1.1.22
f3ca8000 f3cb0000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f3cb8000 f3cbe000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f3cc7000 f3cce000 r-xp /usr/lib/libminizip.so.1.0.0
f3cd6000 f3cd8000 r-xp /usr/lib/libttrace.so.1.1
f3ce0000 f3d27000 r-xp /usr/lib/libsndfile.so.1.0.26
f3d33000 f3d7c000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f3d85000 f3d8a000 r-xp /usr/lib/libjson.so.0.0.1
f5623000 f5729000 r-xp /usr/lib/libicuuc.so.57.1
f573f000 f58c7000 r-xp /usr/lib/libicui18n.so.57.1
f58d7000 f58e4000 r-xp /usr/lib/libail.so.0.1.0
f58ed000 f58f0000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f58f8000 f58fb000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f5903000 f5964000 r-xp /usr/lib/libasound.so.2.0.0
f596e000 f5984000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f598c000 f5990000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f5998000 f59d9000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
f59e2000 f59e4000 r-xp /usr/lib/libdri2.so.0.0.0
f59ec000 f59f4000 r-xp /usr/lib/libdrm.so.2.4.0
f59fc000 f5a02000 r-xp /usr/lib/libxcb-render.so.0.0.0
f5a0a000 f5a0b000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f5a14000 f5a18000 r-xp /usr/lib/libEGL.so.1.4
f5a28000 f5a39000 r-xp /usr/lib/libGLESv2.so.2.0
f5a49000 f5a91000 r-xp /usr/lib/libmdm.so.1.2.62
f5a92000 f5a99000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f5aa1000 f5aac000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f5ab9000 f5ad2000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f5ada000 f5adf000 r-xp /usr/lib/libstorage.so.0.1
f5ae7000 f5aec000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f5af4000 f5b2c000 r-xp /usr/lib/libpulse.so.0.16.2
f5b2d000 f5b31000 r-xp /usr/lib/libmmfsession.so.0.0.0
f5b3a000 f5b51000 r-xp /usr/lib/libmmfsound.so.0.1.0
f5b63000 f5b84000 r-xp /usr/lib/libexif.so.12.3.3
f5b97000 f5ba0000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
f5ba8000 f5bb5000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
f5bbe000 f5bc9000 r-xp /usr/lib/libtbm.so.1.0.0
f5bd1000 f5bd6000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f5bde000 f5c96000 r-xp /usr/lib/libcairo.so.2.11200.14
f5ca1000 f5d3c000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
f5d48000 f5d98000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
f5d9e000 f5db0000 r-xp /usr/lib/libcapi-media-camera.so.0.1.35
f5db8000 f5dd9000 r-xp /usr/lib/libefl-extension.so.0.1.0
f5de1000 f5de6000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5dee000 f5df6000 r-xp /usr/lib/libcapi-media-recorder.so.0.1.28
f5dfe000 f5e05000 r-xp /opt/usr/apps/org.example.clover/bin/clover
f5fa7000 f5fb1000 r-xp /lib/libnss_files-2.13.so
f5fba000 f6089000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f609f000 f60c3000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f60cc000 f60d2000 r-xp /usr/lib/libappsvc.so.0.1.0
f60da000 f60dc000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f60e5000 f60e9000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f60f5000 f6100000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f6108000 f610a000 r-xp /usr/lib/libiniparser.so.0
f6113000 f6118000 r-xp /usr/lib/libappcore-common.so.1.1
f6120000 f6122000 r-xp /usr/lib/libcamsrcjpegenc.so.0.0.0
f612a000 f612e000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f613b000 f613d000 r-xp /usr/lib/libXau.so.6.0.0
f6145000 f614c000 r-xp /lib/libcrypt-2.13.so
f617c000 f617e000 r-xp /usr/lib/libiri.so
f6187000 f6330000 r-xp /usr/lib/libcrypto.so.1.0.0
f6350000 f6397000 r-xp /usr/lib/libssl.so.1.0.0
f63a3000 f63d1000 r-xp /usr/lib/libidn.so.11.5.44
f63d9000 f63e2000 r-xp /usr/lib/libcares.so.2.1.0
f63ec000 f63ff000 r-xp /usr/lib/libxcb.so.1.1.0
f6408000 f640a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6412000 f6414000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f641d000 f64e9000 r-xp /usr/lib/libxml2.so.2.7.8
f64f6000 f64f8000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6501000 f6506000 r-xp /usr/lib/libffi.so.5.0.10
f650e000 f650f000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6517000 f651a000 r-xp /lib/libattr.so.1.1.0
f6522000 f65b6000 r-xp /usr/lib/libstdc++.so.6.0.16
f65c9000 f65e6000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f65f0000 f6608000 r-xp /usr/lib/libpng12.so.0.50.0
f6610000 f6626000 r-xp /lib/libexpat.so.1.6.0
f6630000 f6674000 r-xp /usr/lib/libcurl.so.4.3.0
f667d000 f6687000 r-xp /usr/lib/libXext.so.6.4.0
f6690000 f6694000 r-xp /usr/lib/libXtst.so.6.1.0
f669c000 f66a2000 r-xp /usr/lib/libXrender.so.1.3.0
f66aa000 f66b0000 r-xp /usr/lib/libXrandr.so.2.2.0
f66b8000 f66b9000 r-xp /usr/lib/libXinerama.so.1.0.0
f66c2000 f66cb000 r-xp /usr/lib/libXi.so.6.1.0
f66d3000 f66d6000 r-xp /usr/lib/libXfixes.so.3.1.0
f66de000 f66e0000 r-xp /usr/lib/libXgesture.so.7.0.0
f66e8000 f66ea000 r-xp /usr/lib/libXcomposite.so.1.0.0
f66f2000 f66f4000 r-xp /usr/lib/libXdamage.so.1.1.0
f66fc000 f6703000 r-xp /usr/lib/libXcursor.so.1.0.2
f670b000 f670e000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f6716000 f671a000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f6723000 f6728000 r-xp /usr/lib/libecore_fb.so.1.7.99
f6731000 f6812000 r-xp /usr/lib/libX11.so.6.3.0
f681d000 f6840000 r-xp /usr/lib/libjpeg.so.8.0.2
f6858000 f686e000 r-xp /lib/libz.so.1.2.5
f6876000 f6878000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6880000 f68f5000 r-xp /usr/lib/libsqlite3.so.0.8.6
f68ff000 f6919000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6921000 f6955000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f695e000 f6a31000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a3c000 f6a4c000 r-xp /lib/libresolv-2.13.so
f6a50000 f6a68000 r-xp /usr/lib/liblzma.so.5.0.3
f6a70000 f6a73000 r-xp /lib/libcap.so.2.21
f6a7b000 f6aaa000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6ab2000 f6ab3000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f6abb000 f6ac1000 r-xp /usr/lib/libecore_imf.so.1.7.99
f6ac9000 f6ae0000 r-xp /usr/lib/liblua-5.1.so
f6ae9000 f6af0000 r-xp /usr/lib/libembryo.so.1.7.99
f6af8000 f6afe000 r-xp /lib/librt-2.13.so
f6b07000 f6b5d000 r-xp /usr/lib/libpixman-1.so.0.28.2
f6b6a000 f6bc0000 r-xp /usr/lib/libfreetype.so.6.11.3
f6bcc000 f6bf4000 r-xp /usr/lib/libfontconfig.so.1.8.0
f6bf5000 f6c3a000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6c43000 f6c56000 r-xp /usr/lib/libfribidi.so.0.3.1
f6c5e000 f6c78000 r-xp /usr/lib/libecore_con.so.1.7.99
f6c81000 f6c8a000 r-xp /usr/lib/libedbus.so.1.7.99
f6c92000 f6ce2000 r-xp /usr/lib/libecore_x.so.1.7.99
f6ce4000 f6ced000 r-xp /usr/lib/libvconf.so.0.2.45
f6cf5000 f6d06000 r-xp /usr/lib/libecore_input.so.1.7.99
f6d0e000 f6d13000 r-xp /usr/lib/libecore_file.so.1.7.99
f6d1b000 f6d3d000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6d46000 f6d87000 r-xp /usr/lib/libeina.so.1.7.99
f6d90000 f6da9000 r-xp /usr/lib/libeet.so.1.7.99
f6dba000 f6e23000 r-xp /lib/libm-2.13.so
f6e2c000 f6e32000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e3b000 f6e3c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e44000 f6e67000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e6f000 f6e74000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e7c000 f6ea6000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6eaf000 f6ec6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ece000 f6ed9000 r-xp /lib/libunwind.so.8.0.1
f6f06000 f6f24000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f2e000 f7052000 r-xp /lib/libc-2.13.so
f7060000 f7068000 r-xp /lib/libgcc_s-4.6.so.1
f7069000 f706d000 r-xp /usr/lib/libsmack.so.1.0.0
f7076000 f707c000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f7084000 f7154000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7155000 f71b3000 r-xp /usr/lib/libedje.so.1.7.99
f71bd000 f71d4000 r-xp /usr/lib/libecore.so.1.7.99
f71eb000 f72b9000 r-xp /usr/lib/libevas.so.1.7.99
f72de000 f741a000 r-xp /usr/lib/libelementary.so.1.7.99
f7431000 f7445000 r-xp /lib/libpthread-2.13.so
f7450000 f7452000 r-xp /usr/lib/libdlog.so.0.0.0
f745a000 f745d000 r-xp /usr/lib/libbundle.so.0.1.22
f7465000 f7467000 r-xp /lib/libdl-2.13.so
f7470000 f747d000 r-xp /usr/lib/libaul.so.0.1.0
f748e000 f7494000 r-xp /usr/lib/libappcore-efl.so.1.1
f749d000 f74a1000 r-xp /usr/lib/libsys-assert.so
f74aa000 f74c7000 r-xp /lib/ld-2.13.so
f74d0000 f74d5000 r-xp /usr/bin/launchpad-loader
f79e5000 f7b95000 rw-p [heap]
ffeca000 ffeeb000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10616)
Call Stack Count: 12
 0: ecore_timer_cb + 0xc9 (0xf5e00562) [/opt/usr/apps/org.example.clover/bin/clover] + 0x2562
 1: (0xf71cc1f9) [/usr/lib/libecore.so.1] + 0xf1f9
 2: (0xf71cc2ef) [/usr/lib/libecore.so.1] + 0xf2ef
 3: (0xf71c92f3) [/usr/lib/libecore.so.1] + 0xc2f3
 4: ecore_main_loop_begin + 0x30 (0xf71c9879) [/usr/lib/libecore.so.1] + 0xc879
 5: appcore_efl_main + 0x332 (0xf7491b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
 6: ui_app_main + 0xb0 (0xf612c421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 7: uib_app_run + 0xea (0xf5e00f23) [/opt/usr/apps/org.example.clover/bin/clover] + 0x2f23
 8: main + 0x34 (0xf5e00489) [/opt/usr/apps/org.example.clover/bin/clover] + 0x2489
 9: (0xf74d1a53) [/opt/usr/apps/org.example.clover/bin/clover] + 0x1a53
10: __libc_start_main + 0x114 (0xf6f4585c) [/lib/libc.so.6] + 0x1785c
11: (0xf74d1e0c) [/opt/usr/apps/org.example.clover/bin/clover] + 0x1e0c
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
.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 14 2
05-25 17:10:41.091+0900 E/PKGMGR_CERT(10606): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 15 2
05-25 17:10:41.101+0900 E/PKGMGR_CERT(10606): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(575) > Transaction Commit and End
05-25 17:10:41.111+0900 E/PKGMGR_OBSERVER(10607): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[106070002] pkg_type[tpk] pkgid[org.example.clover] key[install_percent] val[60]
05-25 17:10:41.141+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 10348 pgid = 10348
05-25 17:10:41.141+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 9
05-25 17:10:41.171+0900 E/WMS     ( 2450): wms_event_handler.c: _wms_event_handler_cb_log_package(4744) > package [_________] callback : [INSTALL, PROCESSING]
05-25 17:10:41.191+0900 E/rpm-installer(10606): installer-util.c: _installer_util_get_configuration_value(601) > [signature]=[on]
05-25 17:10:41.191+0900 E/rpm-installer(10606): coretpk-installer.c: _coretpk_installer_apply_smack(3199) > groupid = [ZbkpjytCHxHTzXbJl8Xwjt9cHGJUAGFKvGY2rqfDJT0=] for shared/trusted.
05-25 17:10:41.241+0900 I/AUL_AMD ( 2490): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10348
05-25 17:10:41.241+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(10348)
05-25 17:10:41.251+0900 E/rpm-installer(10606): coretpk-installer.c: __post_install_for_mmc(742) > (handle == NULL) handle is NULL.
05-25 17:10:41.271+0900 E/PKGMGR_OBSERVER(10607): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[106070002] pkg_type[tpk] pkgid[org.example.clover] key[install_percent] val[100]
05-25 17:10:41.291+0900 E/WMS     ( 2450): wms_event_handler.c: _wms_event_handler_cb_log_package(4744) > package [_________] callback : [INSTALL, PROCESSING]
05-25 17:10:41.321+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
05-25 17:10:41.321+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 10256 pgid = -1
05-25 17:10:41.321+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 9
05-25 17:10:41.321+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
05-25 17:10:41.321+0900 I/AUL_AMD ( 2490): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10256
05-25 17:10:41.321+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(10256)
05-25 17:10:41.331+0900 E/rpm-installer(10606): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
05-25 17:10:41.561+0900 I/AUL_AMD ( 2490): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10257
05-25 17:10:41.561+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(10257)
05-25 17:10:42.411+0900 I/AUL_PAD (10616): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
05-25 17:10:42.541+0900 W/MM_CAMCORDER(10618): mm_camcorder_internal.c: _mmcamcorder_constructor(203) >  start
05-25 17:10:42.541+0900 W/MM_CAMCORDER(10618): mm_camcorder_internal.c: _mmcamcorder_constructor(213) >  done
05-25 17:10:42.541+0900 I/efl-extension(10618): efl_extension.c: eext_mod_init(40) > Init
05-25 17:10:42.661+0900 E/PKGMGR_SERVER(10605): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=0, queue_status=1] 
05-25 17:10:42.661+0900 I/efl-extension(10617): efl_extension.c: eext_mod_init(40) > Init
05-25 17:10:42.741+0900 I/UXT     (10617): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
05-25 17:10:42.821+0900 I/AUL_PAD (10617): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
05-25 17:10:42.851+0900 E/MALI    (10617): mali_egl_winsys.c: window_surface_new(889) >  Create Window, it runs with MALI_X11_ASYNC_PAGEFLIP 1 
05-25 17:10:42.981+0900 E/PKGMGR_OBSERVER(10607): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[106070002] pkg_type[tpk] pkgid[org.example.clover] key[end] val[ok]
05-25 17:10:42.991+0900 W/W_HOME  ( 2724): clock_event.c: _pkgmgr_event_cb(247) > Pkg:org.example.clover is updated, need to check validation
05-25 17:10:42.991+0900 W/W_HOME  ( 2724): clock_event.c: _pkgmgr_event_cb(251) > attacheck clock:com.samsung.chronograph16
05-25 17:10:43.001+0900 W/AUL_AMD ( 2490): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(org.example.clover), key(end), value(ok)
05-25 17:10:43.021+0900 E/WMS     ( 2450): wms_event_handler.c: _wms_event_handler_cb_log_package(4744) > package [_________] callback : [INSTALL, COMPLETED]
05-25 17:10:43.021+0900 E/WMS     ( 2450): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7080) > package install complete
05-25 17:10:43.021+0900 E/WMS     ( 2450): wms_event_handler.c: _wms_event_handler_package_install_event(5034) > 
05-25 17:10:43.021+0900 E/WMS     ( 2450): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(2040) > Found in install_req_list?[0], index[-1]
05-25 17:10:43.021+0900 E/WMS     ( 2450): wms_event_handler.c: _wms_event_handler_package_install_event(5060) > triggered from Gear itself.
05-25 17:10:43.081+0900 W/APPS    ( 2724): AppsViewNecklace.cpp: onTouchEventCancel(4949) >  touch cancel
05-25 17:10:43.081+0900 E/STARTER ( 2650): pkg-monitor.c: _pkg_monitor_get_metadata(136) > [_pkg_monitor_get_metadata:136] Failed to get metadata value[-2]
05-25 17:10:43.091+0900 E/WMS     ( 2450): wms_db.c: wms_db_package_event_insert_record(190) > 
05-25 17:10:43.091+0900 E/PKGMGR_INFO(10607): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(1026) > callback is stopped.
05-25 17:10:43.111+0900 E/WMS     ( 2450): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2886) > send_install_response completed : END
05-25 17:10:43.121+0900 E/PKGMGR_OBSERVER(10607): pkg_observer.c: main(620) > OBSERVER end
05-25 17:10:43.131+0900 E/PKGMGR_INFO( 2447): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(922) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
05-25 17:10:43.131+0900 E/PKGMGR_SERVER(10605): pkgmgr-server.c: sighandler(486) > child NORMAL exit [10607]
05-25 17:10:43.581+0900 I/AUL     (10618): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:10:43.591+0900 I/AUL     (10618): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:10:43.591+0900 E/AUL     (10618): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:10:43.591+0900 E/AUL     (10618): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:10:43.601+0900 I/AUL     (10618): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:10:43.611+0900 I/AUL     (10618): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:10:43.611+0900 E/AUL     (10618): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:10:43.611+0900 E/AUL     (10618): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:10:43.621+0900 I/AUL     (10618): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:10:43.631+0900 I/AUL     (10618): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:10:43.631+0900 E/AUL     (10618): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:10:43.631+0900 E/AUL     (10618): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:10:43.641+0900 I/AUL     (10618): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:10:43.651+0900 I/AUL     (10618): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:10:43.661+0900 E/AUL     (10618): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:10:43.661+0900 E/AUL     (10618): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:10:43.671+0900 I/AUL     (10618): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:10:43.681+0900 I/AUL     (10618): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:10:43.681+0900 E/AUL     (10618): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:10:43.681+0900 E/AUL     (10618): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:10:43.691+0900 I/AUL     (10618): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:10:43.701+0900 I/AUL     (10618): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:10:43.701+0900 E/AUL     (10618): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:10:43.701+0900 E/AUL     (10618): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:10:43.711+0900 I/AUL     (10618): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:10:43.721+0900 I/AUL     (10618): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:10:43.721+0900 E/AUL     (10618): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:10:43.721+0900 E/AUL     (10618): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:10:43.731+0900 I/AUL     (10618): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:10:43.741+0900 I/AUL     (10618): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:10:43.741+0900 E/AUL     (10618): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:10:43.751+0900 E/AUL     (10618): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:10:43.771+0900 I/UXT     (10618): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
05-25 17:10:43.911+0900 E/MALI    (10618): mali_egl_winsys.c: window_surface_new(889) >  Create Window, it runs with MALI_X11_ASYNC_PAGEFLIP 1 
05-25 17:10:43.921+0900 W/CoreGL  (10618): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[3] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:10:43.921+0900 W/CoreGL  (10618): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[7] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:10:43.921+0900 W/CoreGL  (10618): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[11] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:10:43.921+0900 W/CoreGL  (10618): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[15] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:10:43.921+0900 W/CoreGL  (10618): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[19] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:10:43.921+0900 W/CoreGL  (10618): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[23] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:10:43.921+0900 W/CoreGL  (10618): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[27] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:10:43.921+0900 W/CoreGL  (10618): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[31] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:10:43.921+0900 W/CoreGL  (10618): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[35] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:10:43.921+0900 W/CoreGL  (10618): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[39] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:10:43.921+0900 W/CoreGL  (10618): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[43] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:10:43.921+0900 W/CoreGL  (10618): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[47] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:10:43.921+0900 W/CoreGL  (10618): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[51] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:10:43.921+0900 W/CoreGL  (10618): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[55] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:10:43.921+0900 W/CoreGL  (10618): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[59] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:10:43.921+0900 W/CoreGL  (10618): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[63] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:10:43.921+0900 W/CoreGL  (10618): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[3] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:10:43.921+0900 W/CoreGL  (10618): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[7] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:10:43.921+0900 W/CoreGL  (10618): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[11] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:10:43.921+0900 W/CoreGL  (10618): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[15] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:10:43.921+0900 W/CoreGL  (10618): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[19] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:10:43.921+0900 W/CoreGL  (10618): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[23] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:10:43.921+0900 W/CoreGL  (10618): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[27] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:10:43.921+0900 W/CoreGL  (10618): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[31] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:10:43.921+0900 W/CoreGL  (10618): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[35] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:10:43.921+0900 W/CoreGL  (10618): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[39] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:10:43.921+0900 W/CoreGL  (10618): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[43] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:10:43.921+0900 W/CoreGL  (10618): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[47] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:10:43.921+0900 W/CoreGL  (10618): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[51] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:10:43.921+0900 W/CoreGL  (10618): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[55] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:10:43.931+0900 W/CoreGL  (10618): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[59] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:10:43.931+0900 W/CoreGL  (10618): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[63] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:10:43.931+0900 W/CoreGL  (10618): coregl_fastpath.c: fastpath_init_context_states(1463) >  [40;31;1mNumber of uniform buffer binding is too big! (64-72)[0m
05-25 17:10:43.931+0900 W/CoreGL  (10618): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
05-25 17:10:43.931+0900 W/CoreGL  (10618): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
05-25 17:10:44.661+0900 E/PKGMGR_SERVER(10605): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=0, queue_status=1] 
05-25 17:10:44.691+0900 E/rpm-installer(10606): rpm-appcore-intf.c: main(273) > ------------------------------------------------
05-25 17:10:44.691+0900 E/rpm-installer(10606): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
05-25 17:10:44.691+0900 E/rpm-installer(10606): rpm-appcore-intf.c: main(275) > ------------------------------------------------
05-25 17:10:44.701+0900 E/PKGMGR_SERVER(10605): pkgmgr-server.c: sighandler(486) > child NORMAL exit [10606]
05-25 17:10:44.731+0900 E/RESOURCED( 2613): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/10606/oom_score_adj failed
05-25 17:10:44.731+0900 E/RESOURCED( 2613): proc-main.c: resourced_proc_status_change(1504) > Empty pid or process not exists. 10606
05-25 17:10:44.981+0900 I/AUL     (10628): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
05-25 17:10:44.981+0900 I/AUL     (10628): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:10:44.981+0900 E/AUL     (10628): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:10:44.981+0900 E/AUL     (10628): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:10:46.661+0900 E/PKGMGR_SERVER(10605): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=1, queue_status=1] 
05-25 17:10:46.661+0900 E/PKGMGR_SERVER(10605): pkgmgr-server.c: main(2281) > package manager server terminated.
05-25 17:10:47.141+0900 W/AUL     (10693): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.clover)
05-25 17:10:47.141+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 0
05-25 17:10:47.161+0900 I/AUL_AMD ( 2490): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
05-25 17:10:47.181+0900 I/AUL_AMD ( 2490): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
05-25 17:10:47.181+0900 E/AUL_AMD ( 2490): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
05-25 17:10:47.181+0900 W/AUL_AMD ( 2490): amd_launch.c: _start_app(1782) > caller pid : 10693
05-25 17:10:47.211+0900 E/RESOURCED( 2613): block.c: block_prelaunch_state(138) > insert data org.example.clover, table num : 3
05-25 17:10:47.211+0900 W/AUL_AMD ( 2490): amd_launch.c: _start_app(2218) > pad pid(-5)
05-25 17:10:47.211+0900 W/AUL_PAD ( 3264): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
05-25 17:10:47.211+0900 W/AUL_PAD ( 3264): launchpad.c: __send_result_to_caller(272) > Check app launching
05-25 17:10:47.211+0900 W/AUL_PAD (10616): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
05-25 17:10:47.211+0900 W/AUL_PAD (10616): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
05-25 17:10:47.221+0900 W/AUL_PAD (10616): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
05-25 17:10:47.221+0900 W/AUL_PAD (10616): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.clover)
05-25 17:10:47.281+0900 I/efl-extension(10616): efl_extension.c: eext_mod_init(40) > Init
05-25 17:10:47.281+0900 W/AUL_PAD (10616): launchpad_loader.c: main(690) > [candidate] dlsym
05-25 17:10:47.281+0900 W/AUL_PAD (10616): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.clover)
05-25 17:10:47.281+0900 I/CAPI_APPFW_APPLICATION(10616): app_main.c: ui_app_main(704) > app_efl_main
05-25 17:10:47.291+0900 I/CAPI_APPFW_APPLICATION(10616): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-25 17:10:47.311+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.clover) pid(10616) type(uiapp) bg(0)
05-25 17:10:47.311+0900 W/AUL_AMD ( 2490): amd_status.c: __socket_monitor_cb(1277) > (10616) was created
05-25 17:10:47.311+0900 W/AUL     (10693): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10616)
05-25 17:10:47.321+0900 W/STARTER ( 2650): pkg-monitor.c: _app_mgr_status_cb(394) > [_app_mgr_status_cb:394] Launch request [10616]
05-25 17:10:47.391+0900 E/EFL     (10616): ecore_evas<10616> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-25 17:10:47.401+0900 W/W_HOME  ( 2724): event_manager.c: _ecore_x_message_cb(428) > state: 0 -> 1
05-25 17:10:47.401+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:10:47.401+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:10:47.401+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:10:47.401+0900 W/W_HOME  ( 2724): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 0
05-25 17:10:47.401+0900 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
05-25 17:10:47.401+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
05-25 17:10:47.451+0900 E/EFL     (10616): elementary<10616> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
05-25 17:10:47.461+0900 E/EFL     (10616): elementary<10616> elc_naviframe.c:2950 elm_naviframe_item_push() item(0xf7b43b80) will be pushed
05-25 17:10:47.471+0900 W/SHealthCommon( 2843): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:1[0;m
05-25 17:10:47.471+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [4292.817723] dpms[3 -> 0]sync[0]
05-25 17:10:47.471+0900 I/TDM     ( 1552): 
05-25 17:10:47.471+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [4292.817839] dpms[0 -> 0]done
05-25 17:10:47.471+0900 I/TDM     ( 1552): 
05-25 17:10:47.481+0900 W/wnotibp ( 3231): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(91) > ::APP:: view state=0, 2, 0
05-25 17:10:47.481+0900 I/wnotibp ( 3231): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(140) > There is no additional work.
05-25 17:10:47.481+0900 W/STARTER ( 2650): clock-mgr.c: _on_lcd_signal_receive_cb(1579) > [_on_lcd_signal_receive_cb:1579] _on_lcd_signal_receive_cb, 1579, Pre LCD on by [unknown] after screen off time [135039]ms
05-25 17:10:47.481+0900 W/STARTER ( 2650): clock-mgr.c: _pre_lcd_on(1298) > [_pre_lcd_on:1298] Will LCD ON as reserved app[(null)] alpm mode[0]
05-25 17:10:47.481+0900 W/WATCH_CORE( 2779): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOn
05-25 17:10:47.481+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_lcd_status_handler(1250) > Call the time_tick_cb
05-25 17:10:47.481+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:10:47.481+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_lcd_status_handler(1257) > Call widget_provider_update_event
05-25 17:10:47.481+0900 W/W_HOME  ( 2724): dbus.c: _dbus_message_recv_cb(186) > LCD on
05-25 17:10:47.481+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_disable_timer_set(167) > timer set
05-25 17:10:47.481+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_disable_timer_del(157) > timer del
05-25 17:10:47.491+0900 W/W_HOME  ( 2724): gesture.c: _apps_status_get(128) > apps status:0
05-25 17:10:47.491+0900 W/W_HOME  ( 2724): gesture.c: _lcd_on_cb(303) > move_to_clock:1 clock_visible:1 info->offtime:135039
05-25 17:10:47.491+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_schedule(209) > schedule, manual render
05-25 17:10:47.491+0900 W/W_HOME  ( 2724): event_manager.c: _lcd_on_cb(728) > lcd state: 1
05-25 17:10:47.491+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:10:47.491+0900 W/SHealthCommon( 3233): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:1[0;m
05-25 17:10:47.501+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : -147223796[0;m
05-25 17:10:47.501+0900 W/SHealthService( 3233): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-25 17:10:47.501+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
05-25 17:10:47.501+0900 W/SHealthCommon( 3233): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1495670400000.000000[0;m
05-25 17:10:47.501+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-25 17:10:47.501+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
05-25 17:10:47.501+0900 W/W_INDICATOR( 2651): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(285) > [_windicator_dbus_lcd_changed_cb:285] LCD ON signal is received
05-25 17:10:47.511+0900 W/W_INDICATOR( 2651): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] 304, str=[unknown],charge : 0, connected : 0
05-25 17:10:47.511+0900 W/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
05-25 17:10:47.511+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
05-25 17:10:47.511+0900 E/TIZEN_N_RECORDER(10616): recorder.c: __convert_recorder_error_code(193) > [audio-channel] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:10:47.511+0900 E/TIZEN_N_RECORDER(10616): recorder.c: __convert_recorder_error_code(193) > [audio-device] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:10:47.521+0900 I/APP_CORE(10616): appcore-efl.c: __do_app(453) > [APP 10616] Event: RESET State: CREATED
05-25 17:10:47.521+0900 I/CAPI_APPFW_APPLICATION(10616): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-25 17:10:47.531+0900 I/efl-extension( 2724): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-25 17:10:47.531+0900 I/efl-extension( 3070): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-25 17:10:47.531+0900 I/efl-extension( 3265): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-25 17:10:47.531+0900 I/efl-extension( 3231): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-25 17:10:47.531+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
05-25 17:10:47.531+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
05-25 17:10:47.531+0900 I/APP_CORE(10616): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
05-25 17:10:47.531+0900 I/APP_CORE(10616): appcore-efl.c: __do_app(524) > [APP 10616] Initial Launching, call the resume_cb
05-25 17:10:47.531+0900 I/CAPI_APPFW_APPLICATION(10616): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-25 17:10:47.531+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
05-25 17:10:47.541+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
05-25 17:10:47.541+0900 W/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-25 17:10:47.541+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
05-25 17:10:47.541+0900 I/HIGEAR  ( 3216): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
05-25 17:10:47.541+0900 W/APP_CORE(10616): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3600002
05-25 17:10:47.551+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_set_info(1442) > [4292.890878] layer(0x874fb8) not usable
05-25 17:10:47.551+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_set_info(1459) > [4292.890934] layer(0x874fb8) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
05-25 17:10:47.551+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_layer_set_info(1578) > [4292.890951] layer[0x874b08]zpos[1]
05-25 17:10:47.551+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_set_info(1442) > [4292.891016] layer(0x874f48) not usable
05-25 17:10:47.551+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_set_info(1459) > [4292.891029] layer(0x874f48) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
05-25 17:10:47.551+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_layer_set_info(1578) > [4292.891044] layer[0x8749e8]zpos[0]
05-25 17:10:47.551+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_set_info(1442) > [4292.891071] layer(0x875008) not usable
05-25 17:10:47.551+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_set_info(1459) > [4292.891082] layer(0x875008) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
05-25 17:10:47.551+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_layer_set_info(1578) > [4292.891096] layer[0x874c28]zpos[2]
05-25 17:10:47.551+0900 W/SHealthCommon( 3233): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.widget.hrlog (916859)]][0;m
05-25 17:10:47.611+0900 W/W_HOME  ( 2724): event_manager.c: _window_visibility_cb(473) > Window [0x1E00003] is now visible(1)
05-25 17:10:47.611+0900 W/W_HOME  ( 2724): event_manager.c: _window_visibility_cb(483) > state: 1 -> 0
05-25 17:10:47.611+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:10:47.611+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:10:47.611+0900 W/W_HOME  ( 2724): main.c: _window_visibility_cb(964) > Window [0x1E00003] is now visible(1)
05-25 17:10:47.621+0900 I/APP_CORE( 2724): appcore-efl.c: __do_app(453) > [APP 2724] Event: PAUSE State: PAUSED
05-25 17:10:47.621+0900 I/wnotib  ( 2724): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
05-25 17:10:47.621+0900 E/wnotib  ( 2724): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-25 17:10:47.621+0900 W/wnotib  ( 2724): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [3], notiboard card appending count [8].
05-25 17:10:47.631+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2724) status(bg) type(uiapp)
05-25 17:10:47.631+0900 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2724] goes to (4)
05-25 17:10:47.631+0900 E/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2724)'s state(4)
05-25 17:10:47.631+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_unset_buffer(1602) > [4292.975864] layer(0x874f48) now usable
05-25 17:10:47.631+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [4292.975898] layer[0x8749e8]zpos[0]
05-25 17:10:47.631+0900 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[10616] goes to (3)
05-25 17:10:47.631+0900 W/AUL_AMD ( 2490): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-25 17:10:47.631+0900 W/AUL_AMD ( 2490): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
05-25 17:10:47.631+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.clover) pid(10616) status(fg) type(uiapp)
05-25 17:10:47.651+0900 W/SHealthWidget( 2843): WidgetMain.cpp: widget_update(147) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.widget.hrlog (916859), msgName: timeline_summary_updated[0;m
05-25 17:10:47.651+0900 W/SHealthCommon( 2843): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
05-25 17:10:47.651+0900 W/SHealthWidget( 2843): HrLogWidgetViewController.cpp: OnIpcProxyMessageReceived(71) > [1;35m##24Hour Widget Service SummaryUpdate Called[0;m
05-25 17:10:47.661+0900 W/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1495732247669.000000, pattern:[HH:mm][0;m
05-25 17:10:47.661+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-25 17:10:47.661+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-25 17:10:47.661+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-25 17:10:47.661+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-25 17:10:47.661+0900 E/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale ko_KR[0;m
05-25 17:10:47.661+0900 W/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:10][0;m
05-25 17:10:47.661+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-25 17:10:47.661+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-25 17:10:47.661+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-25 17:10:47.661+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-25 17:10:47.661+0900 I/CAPI_WIDGET_APPLICATION( 2843): widget_app.c: __provider_update_cb(281) > received updating signal
05-25 17:10:47.661+0900 W/SHealthCommon( 3233): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.1.30][0;m
05-25 17:10:47.671+0900 I/APP_CORE(10616): appcore-efl.c: __do_app(453) > [APP 10616] Event: RESUME State: RUNNING
05-25 17:10:47.681+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
05-25 17:10:47.681+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
05-25 17:10:47.681+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: preference_get_boolean(1173) > preference_get_boolean(3233) : test_healthy_pace error
05-25 17:10:47.691+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_disable_timer_cb(145) > timeout callback expired
05-25 17:10:47.691+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_enable(138) > 0
05-25 17:10:47.691+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
05-25 17:10:47.761+0900 W/STARTER ( 2650): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [unknown]
05-25 17:10:47.761+0900 W/STARTER ( 2650): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[0]
05-25 17:10:47.801+0900 I/HealthDataService( 2909): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-25 17:10:47.821+0900 I/healthData( 3233): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
05-25 17:10:47.821+0900 W/SHealthCommon( 3233): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1495670400000.000000[0;m
05-25 17:10:47.841+0900 W/SHealthCommon( 3233): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.widget.hrlog (916859)]][0;m
05-25 17:10:47.861+0900 W/SHealthCommon( 3233): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.1.30][0;m
05-25 17:10:47.861+0900 W/SHealthWidget( 2843): WidgetMain.cpp: widget_update(147) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.widget.hrlog (916859), msgName: timeline_summary_updated[0;m
05-25 17:10:47.861+0900 W/SHealthCommon( 2843): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
05-25 17:10:47.861+0900 W/SHealthWidget( 2843): HrLogWidgetViewController.cpp: OnIpcProxyMessageReceived(71) > [1;35m##24Hour Widget Service SummaryUpdate Called[0;m
05-25 17:10:47.861+0900 W/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1495732247878.000000, pattern:[HH:mm][0;m
05-25 17:10:47.861+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-25 17:10:47.861+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-25 17:10:47.861+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-25 17:10:47.861+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-25 17:10:47.871+0900 E/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale ko_KR[0;m
05-25 17:10:47.871+0900 W/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:10][0;m
05-25 17:10:47.871+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-25 17:10:47.871+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-25 17:10:47.871+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-25 17:10:47.871+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-25 17:10:47.871+0900 I/CAPI_WIDGET_APPLICATION( 2843): widget_app.c: __provider_update_cb(281) > received updating signal
05-25 17:10:47.871+0900 I/HealthDataService( 2909): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-25 17:10:47.891+0900 I/healthData( 3233): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
05-25 17:10:47.991+0900 E/AUL     ( 2490): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
05-25 17:10:48.421+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 14
05-25 17:10:48.431+0900 W/AUL_AMD ( 2490): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10616
05-25 17:10:48.441+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 12
05-25 17:10:48.451+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 14
05-25 17:10:48.461+0900 W/AUL_AMD ( 2490): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10616
05-25 17:10:48.461+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 12
05-25 17:10:48.641+0900 I/AUL_PAD (10703): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
05-25 17:10:53.841+0900 E/EFL     (10616): ecore_x<10616> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=4299185 button=1
05-25 17:10:53.971+0900 E/EFL     (10616): ecore_x<10616> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=4299315 button=1
05-25 17:10:54.051+0900 I/USR_TAG (10616): record_start
05-25 17:10:54.051+0900 E/TIZEN_N_RECORDER(10616): recorder.c: __convert_recorder_error_code(193) > [recorder_attr_set_time_limit] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:10:54.051+0900 E/TIZEN_N_RECORDER(10616): recorder.c: __convert_recorder_error_code(193) > [recorder_set_filename] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:10:54.051+0900 E/TIZEN_N_RECORDER(10616): recorder.c: __convert_recorder_error_code(193) > [file-format] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:10:54.051+0900 E/TIZEN_N_RECORDER(10616): recorder.c: __convert_recorder_error_code(193) > [audio-encoder] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:10:54.341+0900 E/TIZEN_N_RECORDER(10616): recorder.c: __convert_recorder_error_code(193) > [recorder_start] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:10:54.341+0900 E/EFL     (10616): <10616> elm_main.c:1300 elm_object_disabled_set() safety check failed: obj == NULL
05-25 17:10:54.341+0900 E/EFL     (10616): <10616> elm_main.c:1300 elm_object_disabled_set() safety check failed: obj == NULL
05-25 17:10:54.351+0900 E/EFL     (10616): elementary<10616> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
05-25 17:10:54.371+0900 E/EFL     (10616): elementary<10616> elc_naviframe.c:2950 elm_naviframe_item_push() item(0xf2574ba0) will be pushed
05-25 17:10:54.371+0900 E/EFL     (10616): elementary<10616> elc_naviframe.c:2796 _push_transition_cb() item(0xf2574ba0) will transition
05-25 17:10:54.801+0900 E/EFL     (10616): elementary<10616> elc_naviframe.c:1193 _on_item_push_finished() item(0xf7b43b80) transition finished
05-25 17:10:54.801+0900 E/EFL     (10616): elementary<10616> elc_naviframe.c:1218 _on_item_show_finished() item(0xf2574ba0) transition finished
05-25 17:10:54.981+0900 E/EFL     ( 2318): ecore_x<2318> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x3600002 time=4299717
05-25 17:10:54.981+0900 E/EFL     (10616): ecore_x<10616> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=4299717
05-25 17:10:54.981+0900 E/EFL     ( 2318): ecore_x<2318> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=4299717
05-25 17:10:55.241+0900 I/USR_TAG (10616): loud sound is detected!
05-25 17:10:55.561+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 10616 pgid = 10616
05-25 17:10:55.561+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
05-25 17:10:55.611+0900 W/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
05-25 17:10:55.611+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
05-25 17:10:55.611+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:10:55.611+0900 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2724] goes to (3)
05-25 17:10:55.611+0900 E/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2724)'s state(3)
05-25 17:10:55.611+0900 W/AUL_AMD ( 2490): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-25 17:10:55.611+0900 W/AUL_AMD ( 2490): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
05-25 17:10:55.611+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2724) status(fg) type(uiapp)
05-25 17:10:55.661+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
05-25 17:10:55.661+0900 I/AUL_AMD ( 2490): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10616
05-25 17:10:55.661+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(10616)
05-25 17:10:55.671+0900 W/PROCESSMGR( 2318): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
05-25 17:10:55.671+0900 W/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
05-25 17:10:55.671+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
05-25 17:10:55.671+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:10:55.711+0900 W/CRASH_MANAGER(10717): worker.c: worker_job(1199) > 1110616636c6f149569985

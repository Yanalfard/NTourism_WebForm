function ToNumber(table) {
    if (table === "Home") {
        return 1;
    }
    else if (table === "Destinations") {
        return 2;
    }
    else if (table === "OurServices") {
        return 3;
    }
    else if (table === "News") {
        return 4;
    }
    else if (table === "Rimatours") {
        return 5;
    }
    else if (table === "Event") {
        return 6;
    }
    else if (table === "Residence") {
        return 7;
    }
    else if (table === "Gallery") {
        return 8;
    }
    else if (table === "Collaborate") {
        return 9;
    }
    else if (table === "About Us") {
        return 10;
    }
    else if (table === "Iran") {
        return 11;
    }
}
$(document).ready(function () {
    // $('#Checkboxfile-uploadImgAds1[type=checkbox]:checked');
    //$('#Checkboxfile-uploadImgAds1').prop('checked', true);
    var nameClickAdsInAddData;
    var numbermenu;

    $('#AddImageAdsIndata').hide();
    $('.BtnAddAdsNamePage').click(function () {
        $('#AddImageAdsIndata').show().appendTo($(this).parent());
        nameClickAdsInAddData = $(this).text();
        numbermenu = ToNumber(nameClickAdsInAddData);
        $('#DoneAddAdsImageandlink').text('');


        //////////Home
        if (numbermenu == 1) {
            var P1_1 = SelectAdById(1006);
            var P1_2 = SelectAdById(1007);
            var P1_3 = SelectAdById(1008);
            var P1_4 = SelectAdById(1009);
            var P1_5 = SelectAdById(1010);
            if (P1_1 != null) {
                $('#TextAddAdsUnderImg11').val(P1_1.Link);
                $('#TextAddAdsUnderImg1').val(P1_1.Image);
                $('#image-previewImg1').attr('src', "/Resources/Imges/" + P1_1.Image);
                if (P1_1.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds1').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds1').prop('checked', false);
                }

            }

            if (P1_3 != null) {
                $('#TextAddAdsUnderImg33').val(P1_3.Link);
                $('#TextAddAdsUnderImg3').val(P1_3.Image);
                $('#image-previewImg3').attr('src', "/Resources/Imges/" + P1_3.Image);
                if (P1_3.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds3').prop('checked', true);
                }
            }
            if (P1_4 != null) {
                $('#TextAddAdsUnderImg44').val(P1_4.Link);
                $('#TextAddAdsUnderImg4').val(P1_4.Image);
                $('#image-previewImg4').attr('src', "/Resources/Imges/" + P1_4.Image);
                if (P1_4.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds4').prop('checked', true);
                }
            }
            if (P1_5 != null) {
                $('#TextAddAdsUnderImg55').val(P1_5.Link);
                $('#TextAddAdsUnderImg5').val(P1_5.Image);
                $('#image-previewImg5').attr('src', "/Resources/Imges/" + P1_5.Image);
                if (P1_5.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds5').prop('checked', true);
                }
            }
        }
        else if (numbermenu == 2) {
            //////////Destinations
            var P2_1 = SelectAdById(1011);
            var P2_2 = SelectAdById(1012);
            var P2_3 = SelectAdById(1013);
            var P2_4 = SelectAdById(1014);
            var P2_5 = SelectAdById(1015);
            if (P2_1 != null) {
                $('#TextAddAdsUnderImg11').val(P2_1.Link);
                $('#TextAddAdsUnderImg1').val(P2_1.Image);
                $('#image-previewImg1').attr('src', "/Resources/Imges/" + P2_1.Image);
                if (P2_1.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds1').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds1').prop('checked', false);
                }

            }

            if (P2_3 != null) {
                $('#TextAddAdsUnderImg33').val(P2_3.Link);
                $('#TextAddAdsUnderImg3').val(P2_3.Image);
                $('#image-previewImg3').attr('src', "/Resources/Imges/" + P2_3.Image);
                if (P2_3.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds3').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds3').prop('checked', false);
                }
            }
            if (P2_4 != null) {
                $('#TextAddAdsUnderImg44').val(P2_4.Link);
                $('#TextAddAdsUnderImg4').val(P2_4.Image);
                $('#image-previewImg4').attr('src', "/Resources/Imges/" + P2_4.Image);
                if (P2_4.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds4').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds4').prop('checked', false);
                }
            }
            if (P2_5 != null) {
                $('#TextAddAdsUnderImg55').val(P2_5.Link);
                $('#TextAddAdsUnderImg5').val(P2_5.Image);
                $('#image-previewImg5').attr('src', "/Resources/Imges/" + P2_5.Image);
                if (P2_5.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds5').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds5').prop('checked', false);
                }
            }
        }
        else if (numbermenu == 3) {
            var P3_1 = SelectAdById(1016);
            var P3_2 = SelectAdById(1017);
            var P3_3 = SelectAdById(1018);
            var P3_4 = SelectAdById(1019);
            var P3_5 = SelectAdById(1020);
            if (P3_1 != null) {
                $('#TextAddAdsUnderImg11').val(P3_1.Link);
                $('#TextAddAdsUnderImg1').val(P3_1.Image);
                $('#image-previewImg1').attr('src', "/Resources/Imges/" + P3_1.Image);
                if (P3_1.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds1').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds1').prop('checked', false);
                }
            }

            if (P3_3 != null) {
                $('#TextAddAdsUnderImg33').val(P3_3.Link);
                $('#TextAddAdsUnderImg3').val(P3_3.Image);
                $('#image-previewImg3').attr('src', "/Resources/Imges/" + P3_3.Image);
                if (P3_3.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds3').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds3').prop('checked', false);
                }
            }
            if (P3_4 != null) {
                $('#TextAddAdsUnderImg44').val(P3_4.Link);
                $('#TextAddAdsUnderImg4').val(P3_4.Image);
                $('#image-previewImg4').attr('src', "/Resources/Imges/" + P3_4.Image);
                if (P3_4.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds4').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds4').prop('checked', false);
                }
            }
            if (P3_5 != null) {
                $('#TextAddAdsUnderImg55').val(P3_5.Link);
                $('#TextAddAdsUnderImg5').val(P3_5.Image);
                $('#image-previewImg5').attr('src', "/Resources/Imges/" + P3_5.Image);
                if (P3_5.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds5').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds5').prop('checked', false);
                }
            }
        }
        else if (numbermenu == 4) {
            var P4_1 = SelectAdById(1021);
            var P4_2 = SelectAdById(1022);
            var P4_3 = SelectAdById(1023);
            var P4_4 = SelectAdById(1024);
            var P4_5 = SelectAdById(1025);
            if (P4_1 != null) {
                $('#TextAddAdsUnderImg11').val(P4_1.Link);
                $('#TextAddAdsUnderImg1').val(P4_1.Image);
                $('#image-previewImg1').attr('src', "/Resources/Imges/" + P4_1.Image);
                if (P4_1.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds1').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds1').prop('checked', false);
                }
            }

            if (P4_3 != null) {
                $('#TextAddAdsUnderImg33').val(P4_3.Link);
                $('#TextAddAdsUnderImg3').val(P4_3.Image);
                $('#image-previewImg3').attr('src', "/Resources/Imges/" + P4_3.Image);
                if (P4_3.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds3').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds3').prop('checked', false);
                }
            }
            if (P4_4 != null) {
                $('#TextAddAdsUnderImg44').val(P4_4.Link);
                $('#TextAddAdsUnderImg4').val(P4_4.Image);
                $('#image-previewImg4').attr('src', "/Resources/Imges/" + P4_4.Image);
                if (P4_4.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds4').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds4').prop('checked', false);
                }
            }
            if (P4_5 != null) {
                $('#TextAddAdsUnderImg55').val(P4_5.Link);
                $('#TextAddAdsUnderImg5').val(P4_5.Image);
                $('#image-previewImg5').attr('src', "/Resources/Imges/" + P5_5.Image);
                if (P4_5.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds5').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds5').prop('checked', false);
                }
            }
        }
        else if (numbermenu == 5) {
            var P5_1 = SelectAdById(1026);
            var P5_2 = SelectAdById(1027);
            var P5_3 = SelectAdById(1028);
            var P5_4 = SelectAdById(1029);
            var P5_5 = SelectAdById(1030);
            if (P5_1 != null) {
                $('#TextAddAdsUnderImg11').val(P5_1.Link);
                $('#TextAddAdsUnderImg1').val(P5_1.Image);
                $('#image-previewImg1').attr('src', "/Resources/Imges/" + P5_1.Image);
                if (P5_1.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds1').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds1').prop('checked', false);
                }
            }

            if (P5_3 != null) {
                $('#TextAddAdsUnderImg33').val(P5_3.Link);
                $('#TextAddAdsUnderImg3').val(P5_3.Image);
                $('#image-previewImg3').attr('src', "/Resources/Imges/" + P5_3.Image);
                if (P5_3.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds3').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds3').prop('checked', false);
                }
            }
            if (P5_4 != null) {
                $('#TextAddAdsUnderImg44').val(P5_4.Link);
                $('#TextAddAdsUnderImg4').val(P5_4.Image);
                $('#image-previewImg4').attr('src', "/Resources/Imges/" + P5_4.Image);
                if (P5_4.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds4').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds4').prop('checked', false);
                }
            }
            if (P5_5 != null) {
                $('#TextAddAdsUnderImg55').val(P5_5.Link);
                $('#TextAddAdsUnderImg5').val(P5_5.Image);
                $('#image-previewImg5').attr('src', "/Resources/Imges/" + P5_5.Image);
                if (P5_5.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds5').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds5').prop('checked', false);
                }
            }


        }
        else if (numbermenu == 6) {
            var P6_1 = SelectAdById(1031);
            var P6_2 = SelectAdById(1032);
            var P6_3 = SelectAdById(1033);
            var P6_4 = SelectAdById(1034);
            var P6_5 = SelectAdById(1035);
            if (P6_1 != null) {
                $('#TextAddAdsUnderImg11').val(P6_1.Link);
                $('#TextAddAdsUnderImg1').val(P6_1.Image);
                $('#image-previewImg1').attr('src', "/Resources/Imges/" + P6_1.Image);
                if (P6_1.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds1').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds1').prop('checked', false);
                }
            }

            if (P6_3 != null) {
                $('#TextAddAdsUnderImg33').val(P6_3.Link);
                $('#TextAddAdsUnderImg3').val(P6_3.Image);
                $('#image-previewImg3').attr('src', "/Resources/Imges/" + P6_3.Image);
                if (P6_3.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds3').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds3').prop('checked', false);
                }
            }
            if (P6_4 != null) {
                $('#TextAddAdsUnderImg44').val(P6_4.Link);
                $('#TextAddAdsUnderImg4').val(P6_4.Image);
                $('#image-previewImg4').attr('src', "/Resources/Imges/" + P6_4.Image);
                if (P6_4.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds4').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds4').prop('checked', false);
                }
            }
            if (P6_5 != null) {
                $('#TextAddAdsUnderImg55').val(P6_5.Link);
                $('#TextAddAdsUnderImg5').val(P6_5.Image);
                $('#image-previewImg5').attr('src', "/Resources/Imges/" + P6_5.Image);
                if (P6_5.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds5').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds5').prop('checked', false);
                }
            }
        }
        else if (numbermenu == 7) {
            var P7_1 = SelectAdById(1036);
            var P7_2 = SelectAdById(1037);
            var P7_3 = SelectAdById(1038);
            var P7_4 = SelectAdById(1039);
            var P7_5 = SelectAdById(1040);
            if (P7_1 != null) {
                $('#TextAddAdsUnderImg11').val(P7_1.Link);
                $('#TextAddAdsUnderImg1').val(P7_1.Image);
                $('#image-previewImg1').attr('src', "/Resources/Imges/" + P7_1.Image);
                if (P7_1.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds1').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds1').prop('checked', false);
                }
            }

            if (P7_3 != null) {
                $('#TextAddAdsUnderImg33').val(P7_3.Link);
                $('#TextAddAdsUnderImg3').val(P7_3.Image);
                $('#image-previewImg3').attr('src', "/Resources/Imges/" + P7_3.Image);
                if (P7_3.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds3').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds3').prop('checked', false);
                }
            }
            if (P7_4 != null) {
                $('#TextAddAdsUnderImg44').val(P7_4.Link);
                $('#TextAddAdsUnderImg4').val(P7_4.Image);
                $('#image-previewImg4').attr('src', "/Resources/Imges/" + P7_4.Image);
                if (P7_4.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds4').prop('checked', true);
                }
            }
            if (P7_5 != null) {
                $('#TextAddAdsUnderImg55').val(P7_5.Link);
                $('#TextAddAdsUnderImg5').val(P7_5.Image);
                $('#image-previewImg5').attr('src', "/Resources/Imges/" + P7_5.Image);
                if (P7_5.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds5').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds5').prop('checked', false);
                }
            }
        }
        else if (numbermenu == 8) {
            var P8_1 = SelectAdById(1041);
            var P8_2 = SelectAdById(1042);
            var P8_3 = SelectAdById(1043);
            var P8_4 = SelectAdById(1044);
            var P8_5 = SelectAdById(1045);
            if (P8_1 != null) {
                $('#TextAddAdsUnderImg11').val(P8_1.Link);
                $('#TextAddAdsUnderImg1').val(P8_1.Image);
                $('#image-previewImg1').attr('src', "/Resources/Imges/" + P8_1.Image);
                if (P8_1.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds1').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds1').prop('checked', false);
                }
            }

            if (P8_3 != null) {
                $('#TextAddAdsUnderImg33').val(P8_3.Link);
                $('#TextAddAdsUnderImg3').val(P8_3.Image);
                $('#image-previewImg3').attr('src', "/Resources/Imges/" + P8_3.Image);
                if (P8_3.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds3').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds3').prop('checked', false);
                }
            }
            if (P8_4 != null) {
                $('#TextAddAdsUnderImg44').val(P8_4.Link);
                $('#TextAddAdsUnderImg4').val(P8_4.Image);
                $('#image-previewImg4').attr('src', "/Resources/Imges/" + P8_4.Image);
                if (P8_4.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds4').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds4').prop('checked', false);
                }
            }
            if (P8_5 != null) {
                $('#TextAddAdsUnderImg55').val(P8_5.Link);
                $('#TextAddAdsUnderImg5').val(P8_5.Image);
                $('#image-previewImg5').attr('src', "/Resources/Imges/" + P8_5.Image);
                if (P8_5.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds5').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds5').prop('checked', false);
                }
            }
        }
        else if (numbermenu == 9) {
            var P9_1 = SelectAdById(1046);
            var P9_2 = SelectAdById(1047);
            var P9_3 = SelectAdById(1048);
            var P9_4 = SelectAdById(1049);
            var P9_5 = SelectAdById(1050);
            if (P9_1 != null) {
                $('#TextAddAdsUnderImg11').val(P9_1.Link);
                $('#TextAddAdsUnderImg1').val(P9_1.Image);
                $('#image-previewImg1').attr('src', "/Resources/Imges/" + P9_1.Image);
                if (P9_1.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds1').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds1').prop('checked', false);
                }
            }

            if (P9_3 != null) {
                $('#TextAddAdsUnderImg33').val(P9_3.Link);
                $('#TextAddAdsUnderImg3').val(P9_3.Image);
                $('#image-previewImg3').attr('src', "/Resources/Imges/" + P9_3.Image);
                if (P9_3.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds3').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds3').prop('checked', false);
                }
            }
            if (P9_4 != null) {
                $('#TextAddAdsUnderImg44').val(P9_4.Link);
                $('#TextAddAdsUnderImg4').val(P9_4.Image);
                $('#image-previewImg4').attr('src', "/Resources/Imges/" + P9_4.Image);
                if (P9_4.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds4').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds4').prop('checked', false);
                }
            }
            if (P9_5 != null) {
                $('#TextAddAdsUnderImg55').val(P9_5.Link);
                $('#TextAddAdsUnderImg5').val(P9_5.Image);
                $('#image-previewImg5').attr('src', "/Resources/Imges/" + P9_5.Image);
                if (P9_5.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds5').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds5').prop('checked', false);
                }
            }
        }
        else if (numbermenu == 10) {
            var P10_1 = SelectAdById(1051);
            var P10_2 = SelectAdById(1052);
            var P10_3 = SelectAdById(1053);
            var P10_4 = SelectAdById(1054);
            var P10_5 = SelectAdById(1055);
            if (P10_1 != null) {
                $('#TextAddAdsUnderImg11').val(P10_1.Link);
                $('#TextAddAdsUnderImg1').val(P10_1.Image);
                $('#image-previewImg1').attr('src', "/Resources/Imges/" + P10_1.Image);
                if (P10_1.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds1').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds1').prop('checked', false);
                }
            }

            if (P10_3 != null) {
                $('#TextAddAdsUnderImg33').val(P10_3.Link);
                $('#TextAddAdsUnderImg3').val(P10_3.Image);
                $('#image-previewImg3').attr('src', "/Resources/Imges/" + P10_3.Image);
                if (P10_3.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds3').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds3').prop('checked', false);
                }
            }
            if (P10_4 != null) {
                $('#TextAddAdsUnderImg44').val(P10_4.Link);
                $('#TextAddAdsUnderImg4').val(P10_4.Image);
                $('#image-previewImg4').attr('src', "/Resources/Imges/" + P10_4.Image);
                if (P10_4.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds4').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds4').prop('checked', false);
                }
            }
            if (P10_5 != null) {
                $('#TextAddAdsUnderImg55').val(P10_5.Link);
                $('#TextAddAdsUnderImg5').val(P10_5.Image);
                $('#image-previewImg5').attr('src', "/Resources/Imges/" + P10_5.Image);
                if (P10_5.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds5').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds5').prop('checked', false);
                }
            }
        }
        else if (numbermenu == 11) {
            var P11_1 = SelectAdById(1056);
            var P11_2 = SelectAdById(1057);
            var P11_3 = SelectAdById(1058);
            var P11_4 = SelectAdById(1059);
            var P11_5 = SelectAdById(1060);
            if (P11_1 != null) {
                $('#TextAddAdsUnderImg11').val(P11_1.Link);
                $('#TextAddAdsUnderImg1').val(P11_1.Image);
                $('#image-previewImg1').attr('src', "/Resources/Imges/" + P11_1.Image);
                if (P11_1.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds1').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds1').prop('checked', false);
                }
            }

            if (P11_3 != null) {
                $('#TextAddAdsUnderImg33').val(P11_3.Link);
                $('#TextAddAdsUnderImg3').val(P11_3.Image);
                $('#image-previewImg3').attr('src', "/Resources/Imges/" + P11_3.Image);
                if (P11_3.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds3').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds3').prop('checked', false);
                }
            }
            if (P11_4 != null) {
                $('#TextAddAdsUnderImg44').val(P11_4.Link);
                $('#TextAddAdsUnderImg4').val(P11_4.Image);
                $('#image-previewImg4').attr('src', "/Resources/Imges/" + P11_4.Image);
                if (P11_4.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds4').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds4').prop('checked', false);
                }
            }
            if (P11_5 != null) {
                $('#TextAddAdsUnderImg55').val(P11_5.Link);
                $('#TextAddAdsUnderImg5').val(P11_5.Image);
                $('#image-previewImg5').attr('src', "/Resources/Imges/" + P11_5.Image);
                if (P11_5.IsAvailable == true) {
                    $('#Checkboxfile-uploadImgAds5').prop('checked', true);
                }
                else {
                    $('#Checkboxfile-uploadImgAds5').prop('checked', false);
                }
            }
        }





    });


    $('#BtnCloaseAdsToDatabase').click(function () {
        $('#AddImageAdsIndata').hide(this);
        $('div.AddAdsCol1ImageStyle div img').attr('src', '');
        $('.TextAddAdsUnderImg').val('');
    });

    $('#BtnSaveAdsToDatabaseAds1').click(function () {

        $('#DoneAddAdsImageandlink').text('');

        if ($('#file-uploadImgAds1').val() == '') {
            alert('Please select file');
            return;
        }
        var formdata = new FormData();
        var file = $('#file-uploadImgAds1')[0];
        var NameLink = $('#TextAddAdsUnderImg11').val();
        formdata.append('file', file.files[0]);

        if ($('#TextAddAdsUnderImg11').val() == '') {
            alert('Please fild link');
            return;
        }
        var Available = false;
        if ($('#Checkboxfile-uploadImgAds1').is(':checked')) {
            Available = true;
        }
        else {
            Available = false;
        }
        if (numbermenu == 1) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 1.1,
                        IsAvailable: Available
                    };
                    DeleteImage(1006);
                    var isUpdated = UpdateAd(ad, 1006);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }
                },

                error: function () {

                }

            });
        }
        else if (numbermenu == 2) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 2.1,
                        IsAvailable: Available
                    };
                    DeleteImage(1011);
                    var isUpdated = UpdateAd(ad, 1011);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 3) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 3.1,
                        IsAvailable: Available
                    };
                    DeleteImage(1016);
                    var isUpdated = UpdateAd(ad, 1016);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 4) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 4.1,
                        IsAvailable: Available
                    };
                    DeleteImage(1021);
                    var isUpdated = UpdateAd(ad, 1021);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 5) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 5.1,
                        IsAvailable: Available
                    };
                    DeleteImage(1026);
                    var isUpdated = UpdateAd(ad, 1026);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 6) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 6.1,
                        IsAvailable: Available
                    };
                    DeleteImage(1031);
                    var isUpdated = UpdateAd(ad, 1031);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 7) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 7.1,
                        IsAvailable: Available
                    };
                    DeleteImage(1036);
                    var isUpdated = UpdateAd(ad, 1036);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 8) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 8.1,
                        IsAvailable: Available
                    };
                    DeleteImage(1041);
                    var isUpdated = UpdateAd(ad, 1041);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 9) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 9.1,
                        IsAvailable: Available
                    };
                    DeleteImage(1046);
                    var isUpdated = UpdateAd(ad, 1046);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 10) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 10.1,
                        IsAvailable: Available
                    };
                    DeleteImage(1051);
                    var isUpdated = UpdateAd(ad, 1051);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 11) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 11.1,
                        IsAvailable: Available
                    };
                    DeleteImage(1056);
                    var isUpdated = UpdateAd(ad, 1056);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }



    });


    $('#BtnSaveAdsToDatabaseAds3').click(function () {

        $('#DoneAddAdsImageandlink').text('');
        if ($('#file-uploadImgAds3').val() == '') {
            alert('Please select file');
            return;
        }
        var formdata = new FormData();
        var file = $('#file-uploadImgAds3')[0];
        var NameLink = $('#TextAddAdsUnderImg33').val();
        formdata.append('file', file.files[0]);

        if ($('#TextAddAdsUnderImg33').val() == '') {
            alert('Please fild link');
            return;
        }
        var Available = false;
        if ($('#Checkboxfile-uploadImgAds3').is(':checked')) {
            Available = true;
        }
        else {
            Available = false;
        }
        if (numbermenu == 1) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 1.3,
                        IsAvailable: Available
                    };
                    DeleteImage(1008);
                    var isUpdated = UpdateAd(ad, 1008);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }
                },

                error: function () {

                }

            });
        }
        else if (numbermenu == 2) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 2.3,
                        IsAvailable: Available
                    };
                    DeleteImage(1013);
                    var isUpdated = UpdateAd(ad, 1013);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 3) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 3.3,
                        IsAvailable: Available
                    };
                    DeleteImage(1018);
                    var isUpdated = UpdateAd(ad, 1018);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 4) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 4.3,
                        IsAvailable: Available
                    };
                    DeleteImage(1023);
                    var isUpdated = UpdateAd(ad, 1023);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 5) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 5.3,
                        IsAvailable: Available
                    };
                    DeleteImage(1028);
                    var isUpdated = UpdateAd(ad, 1028);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 6) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 6.3,
                        IsAvailable: Available
                    };
                    DeleteImage(1033);
                    var isUpdated = UpdateAd(ad, 1033);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 7) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 7.3,
                        IsAvailable: Available
                    };
                    DeleteImage(1038);
                    var isUpdated = UpdateAd(ad, 1038);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 8) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 8.3,
                        IsAvailable: Available
                    };
                    DeleteImage(1043);
                    var isUpdated = UpdateAd(ad, 1043);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 9) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 9.3,
                        IsAvailable: Available
                    };
                    DeleteImage(1048);
                    var isUpdated = UpdateAd(ad, 1048);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 10) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 10.3,
                        IsAvailable: Available
                    };
                    DeleteImage(1053);
                    var isUpdated = UpdateAd(ad, 1053);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 11) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 11.3,
                        IsAvailable: Available
                    };
                    DeleteImage(1058);
                    var isUpdated = UpdateAd(ad, 1058);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

    });


    $('#BtnSaveAdsToDatabaseAds4').click(function () {

        $('#DoneAddAdsImageandlink').text('');
        if ($('#file-uploadImgAds4').val() == '') {
            alert('Please select file');
            return;
        }
        var formdata = new FormData();
        var file = $('#file-uploadImgAds4')[0];
        var NameLink = $('#TextAddAdsUnderImg44').val();
        formdata.append('file', file.files[0]);

        if ($('#TextAddAdsUnderImg44').val() == '') {
            alert('Please fild link');
            return;
        }
        var Available = false;
        if ($('#Checkboxfile-uploadImgAds4').is(':checked')) {
            Available = true;
        }
        else {
            Available = false;
        }
        if (numbermenu == 1) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 1.4,
                        IsAvailable: Available
                    };
                    DeleteImage(1009);
                    var isUpdated = UpdateAd(ad, 1009);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }
                },

                error: function () {

                }

            });
        }
        else if (numbermenu == 2) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 2.4,
                        IsAvailable: Available
                    };
                    DeleteImage(1014);
                    var isUpdated = UpdateAd(ad, 1014);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 3) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 3.4,
                        IsAvailable: Available
                    };
                    DeleteImage(1019);
                    var isUpdated = UpdateAd(ad, 1019);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 4) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 4.4,
                        IsAvailable: Available
                    };
                    DeleteImage(1024);
                    var isUpdated = UpdateAd(ad, 1024);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 5) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 5.4,
                        IsAvailable: Available
                    };
                    DeleteImage(1029);
                    var isUpdated = UpdateAd(ad, 1029);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 6) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 6.4,
                        IsAvailable: Available
                    };
                    DeleteImage(1034);
                    var isUpdated = UpdateAd(ad, 1034);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 7) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 7.4,
                        IsAvailable: Available
                    };
                    DeleteImage(1139);
                    var isUpdated = UpdateAd(ad, 1039);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 8) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 8.4,
                        IsAvailable: Available
                    };
                    DeleteImage(1044);
                    var isUpdated = UpdateAd(ad, 1044);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 9) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 9.4,
                        IsAvailable: Available
                    };
                    DeleteImage(1049);
                    var isUpdated = UpdateAd(ad, 1049);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 10) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 10.4,
                        IsAvailable: Available
                    };
                    DeleteImage(1054);
                    var isUpdated = UpdateAd(ad, 1054);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 11) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 11.4,
                        IsAvailable: Available
                    };
                    DeleteImage(1059);
                    var isUpdated = UpdateAd(ad, 1059);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }



    });


    $('#BtnSaveAdsToDatabaseAds5').click(function () {

        $('#DoneAddAdsImageandlink').text('');
        if ($('#file-uploadImgAds5').val() == '') {
            alert('Please select file');
            return;
        }
        var formdata = new FormData();
        var file = $('#file-uploadImgAds5')[0];
        var NameLink = $('#TextAddAdsUnderImg55').val();
        formdata.append('file', file.files[0]);

        if ($('#TextAddAdsUnderImg55').val() == '') {
            alert('Please fild link');
            return;
        }
        var Available = false;
        if ($('#Checkboxfile-uploadImgAds5').is(':checked')) {
            Available = true;
        }
        else {
            Available = false;
        }
        if (numbermenu == 1) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 1.5,
                        IsAvailable: Available
                    };
                    DeleteImage(1010);
                    var isUpdated = UpdateAd(ad, 1010);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }
                },

                error: function () {

                }

            });
        }
        else if (numbermenu == 2) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 2.5,
                        IsAvailable: Available
                    };
                    DeleteImage(1015);
                    var isUpdated = UpdateAd(ad, 1015);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 3) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 3.5,
                        IsAvailable: Available
                    };
                    DeleteImage(1020);
                    var isUpdated = UpdateAd(ad, 1020);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 4) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 4.5,
                        IsAvailable: Available
                    };
                    DeleteImage(1025);
                    var isUpdated = UpdateAd(ad, 1025);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 5) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 5.5,
                        IsAvailable: Available
                    };
                    DeleteImage(1030);
                    var isUpdated = UpdateAd(ad, 1030);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 6) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 6.5,
                        IsAvailable: Available
                    };
                    DeleteImage(1035);
                    var isUpdated = UpdateAd(ad, 1035);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 7) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 7.5,
                        IsAvailable: Available
                    };
                    DeleteImage(1040);
                    var isUpdated = UpdateAd(ad, 1040);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 8) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 8.5,
                        IsAvailable: Available
                    };
                    DeleteImage(1045);
                    var isUpdated = UpdateAd(ad, 1045);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 9) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 9.5,
                        IsAvailable: Available
                    };
                    DeleteImage(1050);
                    var isUpdated = UpdateAd(ad, 1050);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 10) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 10.5,
                        IsAvailable: Available
                    };
                    DeleteImage(1055);
                    var isUpdated = UpdateAd(ad, 1055);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }

        else if (numbermenu == 11) {
            $.ajax({
                url: '/api/upload/uploadfile',
                type: 'POST',
                data: formdata,
                contentType: false,
                processData: false,
                success: function (imageName) {
                    var image = imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                    var ad = {
                        Image: imageName.toString(),
                        Link: NameLink,
                        PositionId: 11.5,
                        IsAvailable: Available
                    };
                    DeleteImage(1060);
                    var isUpdated = UpdateAd(ad, 1060);
                    if (isUpdated == true) {
                        $('#DoneAddAdsImageandlink').text('Done');
                    }
                    else {
                        $('#DoneAddAdsImageandlink').val('False');
                    }

                },

                error: function () {

                }

            });
        }



    });








    ///////////////////
    function DeleteImage(ImaheName) {
        var selectImgName = SelectAdById(ImaheName);
        if (ImaheName = !null) {
            var employee = new Object();
            employee.Name = selectImgName.Image;
            $.ajax({
                type: "POST",
                url: "/Admin/Home/AjaxPostCall",
                data: JSON.stringify(employee),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                },
                failure: function (response) {
                    alert(response.responseText);
                },
                error: function (response) {
                    alert(response.responseText);
                }
            });
        };
    }

    ////////////////////

    $('#BtnSaveAdsToDatabase').click(function () {


    });

    var inputimg1 = document.getElementById('file-uploadImgAds1');
    inputimg1.addEventListener('change', showFileNameImg1);
    function showFileNameImg1(event) {
        var input = event.srcElement;
        var fileName = input.files[0].name;
        $('#TextAddAdsUnderImg1').val(fileName);
    }
    ////////////////
    var inputimg2 = document.getElementById('file-uploadImgAds2');
    inputimg2.addEventListener('change', showFileNameImg2);
    function showFileNameImg2(event) {

        var input2 = event.srcElement;
        var fileName2 = input2.files[0].name;
        $('#TextAddAdsUnderImg2').val(fileName2);
    }
    ////////////////
    var inputimg3 = document.getElementById('file-uploadImgAds3');
    inputimg3.addEventListener('change', showFileNameImg3);
    function showFileNameImg3(event) {

        var input3 = event.srcElement;
        var fileName3 = input3.files[0].name;
        $('#TextAddAdsUnderImg3').val(fileName3);
    }
    ////////////////
    var inputimg4 = document.getElementById('file-uploadImgAds4');
    inputimg4.addEventListener('change', showFileNameImg4);
    function showFileNameImg4(event) {

        var input4 = event.srcElement;
        var fileName4 = input4.files[0].name;
        $('#TextAddAdsUnderImg4').val(fileName4);
    }

    ////////////////
    var inputimg5 = document.getElementById('file-uploadImgAds5');
    inputimg5.addEventListener('change', showFileNameImg5);
    function showFileNameImg5(event) {

        var input5 = event.srcElement;
        var fileName5 = input5.files[0].name;
        $('#TextAddAdsUnderImg5').val(fileName5);
    }

    function readURLImg1(input) {
        if (input.files && input.files[0]) {
            var reader = new FileReader();
            reader.onload = function (e) {
                $('#image-previewImg1').attr('src', e.target.result);
                $('#image-previewImg1').hide();
                $('#image-previewImg1').fadeIn(650);
            }
            reader.readAsDataURL(input.files[0]);
        }
    }
    $("#file-uploadImgAds1").change(function () {
        readURLImg1(this);
    });
    ////////////////////////

    function readURLImg3(input) {
        if (input.files && input.files[0]) {
            var reader = new FileReader();
            reader.onload = function (e) {
                $('#image-previewImg3').attr('src', e.target.result);
                $('#image-previewImg3').hide();
                $('#image-previewImg3').fadeIn(650);
            }
            reader.readAsDataURL(input.files[0]);
        }
    }
    $("#file-uploadImgAds3").change(function () {
        readURLImg3(this);
    });
    ////////////////////////
    function readURLImg4(input) {
        if (input.files && input.files[0]) {
            var reader = new FileReader();
            reader.onload = function (e) {
                $('#image-previewImg4').attr('src', e.target.result);
                $('#image-previewImg4').hide();
                $('#image-previewImg4').fadeIn(650);
            }
            reader.readAsDataURL(input.files[0]);
        }
    }
    $("#file-uploadImgAds4").change(function () {
        readURLImg4(this);
    });

    ////////////////////////
    function readURLImg5(input) {
        if (input.files && input.files[0]) {
            var reader = new FileReader();
            reader.onload = function (e) {
                $('#image-previewImg5').attr('src', e.target.result);
                $('#image-previewImg5').hide();
                $('#image-previewImg5').fadeIn(650);
            }
            reader.readAsDataURL(input.files[0]);
        }
    }
    $("#file-uploadImgAds5").change(function () {
        readURLImg5(this);
    });

});


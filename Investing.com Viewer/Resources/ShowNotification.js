             var imagePath = jelement.find('img:first-of-type').attr('src');
             var scrollPos = document.body.scrollTop;
             html2canvas(jelement, {
                 onrendered: function(canvas) {
                     window.scrollTo(0, scrollPos);
                     var base64 = canvas.toDataURL('image/png');
                     ai_investing_com_viewer.onNewComment(id, base64, imagePath);
                 }
             });
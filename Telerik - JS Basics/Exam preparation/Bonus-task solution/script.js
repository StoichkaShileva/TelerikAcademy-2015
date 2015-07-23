function s (p){return p[0]<0?p[1]<0?2:0:p[1]>0?1:3}
// ((x>0&&y<0)?3:((x<0&&y>0)?0)))
console.log(s([5,5]));
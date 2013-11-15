encontrar_inversion<-function(a,k,N,v){

  if(k>=N){
    if(a[k]==v){
      i=k;
    }
    else{
      i<-1;
    }
  }
  else{
    #propi<-((N-k)(v-a[k]))/(a[N]-a[
    propi<-round(((N-k)*(v-a[k]))/(a[N]-a[k]),0)+k;


    if (a[propi]==v){
      i<-propi
    }
    else if(a[propi]>v){
      i<-encontrar_inversion(a,k,propi-1,v);
    }
    else{
      i<-encontrar_inversion(a,propi+1,N,v);
    }
  }
  return (i);

}
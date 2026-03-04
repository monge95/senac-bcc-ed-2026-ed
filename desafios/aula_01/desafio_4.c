#include <stdio.h>
#include <stdlib.h>

struct no {
    int info;         
    struct no * prox;
};

struct no * novoNo(int info) {
    struct no * novo = malloc(sizeof(struct no));
    novo->info = info;
    return novo;
}

void delete_last(struct no * lista){
     struct no *curr = lista;
     while(curr->prox->prox != NULL){
         curr = curr->prox;
     }
    free(curr->prox);
    curr->prox = NULL;
}    
/*     voce tem que usar ele apontandopara 2 a frente pq quando ele aponta para um so a frente como ex 
      while(curr->prox != NULL){
          curr = curr->prox;
      }
     free(curr);
     curr = NULL;
     
        voce tem um erro que o curr nul não se aplica a nada ele so funciona dentro da função o curr mas o curr apontando para um espaso de memoria ja é outro caso ele funciona em todo o cistema 
*/ 

void remove_value(struct no *lista, int value){
     struct no *curr = lista;
     
    while(curr->prox != NULL){
        if (curr->prox->info == value){
            struct no *alvo = curr->prox; //pega o endereso do alvo do delet o (b)
            struct no *novaLigacao = alvo->prox; //pega o endereco do e (c)
            curr->prox = novaLigacao; //atualiza o endereso que o (a) aponta
            free(alvo);
            break;
        }
         curr = curr->prox;
     }
  
}


struct no* reverse_list(struct no * lista){
    if(lista == NULL || lista->prox == NULL)
        return lista;

    struct no *novaCabeca = reverse_list(lista->prox);
    lista->prox->prox = lista;
    lista->prox = NULL; 

    return novaCabeca;
}

void print_list(struct no * lista){
   struct no *curr = lista;
    while(curr != NULL){
        
        printf("%d \n", *curr);
         curr = curr->prox;
    }
}


struct no * insert_first(struct no * lista, int info) {
    struct no *novo = novoNo(info);
    if (!novo) return lista;   // se falhar, mantém a lista como estava
    novo->prox = lista;        // novo aponta para a antiga cabeça
    return novo;               // novo vira a cabeça
}


void insert_last(struct no * lista, int info) {
    struct no *novo = novoNo(info);
    // Precisamos encontrar o último elemento da lista. Quando encontramos, adicionamos o novo!
    struct no *curr = lista;
    while (curr->prox != NULL) {
        curr = curr->prox;
    }
    curr->prox = novo;
}

struct no * remove_first(struct no * lista) {
    if (lista == NULL) return NULL; // lista vazia

    struct no *novo_inicio = lista->prox;
    return novo_inicio;
}

int main() {
    printf("desafio 1 \n");
    struct no * lista = novoNo(1);
     insert_last(lista, 2);
     insert_last(lista, 3);
     insert_last(lista, 4);
     insert_last(lista, 5);
     print_list(lista);
     
     printf("\n");
     printf("desafio 2\n");
     delete_last(lista);
     print_list(lista);
     
      printf("\n");
     printf("desafio 3\n");
     remove_value(lista, 2);
     print_list(lista);
     
       printf("\n");
     printf("desafio 4\n");
      lista = reverse_list(lista);
      print_list(lista);
    return 0;
}
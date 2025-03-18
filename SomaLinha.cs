import java.util.Random;

class SomaLinha extends Thread {
    private int[] linha;
        private int indice;

            public SomaLinha(int[] linha, int indice) {
                    this.linha = linha;
                            this.indice = indice;
                                }

                                    @Override
                                        public void run() {
                                                int soma = 0;
                                                        for (int num : linha) {
                                                                    soma += num;
                                                                            }
                                                                                    System.out.println("Linha " + indice + " soma: " + soma);
                                                                                        }
                                                                                        }

                                                                                        public class MatrizThreads {
                                                                                            public static void main(String[] args) {
                                                                                                    int[][] matriz = new int[3][5];
                                                                                                            Random rand = new Random();

                                                                                                                    // Preenche a matriz com números aleatórios
                                                                                                                            for (int i = 0; i < 3; i++) {
                                                                                                                                        for (int j = 0; j < 5; j++) {
                                                                                                                                                        matriz[i][j] = rand.nextInt(100);
                                                                                                                                                                    }
                                                                                                                                                                            }

                                                                                                                                                                                    // Inicia uma thread para cada linha
                                                                                                                                                                                            for (int i = 0; i < 3; i++) {
                                                                                                                                                                                                        new SomaLinha(matriz[i], i).start();
                                                                                                                                                                                                                }
                                                                                                                                                                                                                    }
                                                                                                                                                                                                                    }
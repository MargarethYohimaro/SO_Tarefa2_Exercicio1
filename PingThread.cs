import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;

class PingThread extends Thread {
    private String servidor;
        private String nomeServidor;

            public PingThread(String servidor, String nomeServidor) {
                    this.servidor = servidor;
                            this.nomeServidor = nomeServidor;
                                }

                                    @Override
                                        public void run() {
                                                List<Double> tempos = new ArrayList<>();
                                                        try {
                                                                    Process process = Runtime.getRuntime().exec("ping -4 -c 10 " + servidor);
                                                                                BufferedReader reader = new BufferedReader(new InputStreamReader(process.getInputStream()));
                                                                                            String linha;
                                                                                                        while ((linha = reader.readLine()) != null) {
                                                                                                                        if (linha.contains("time=")) {
                                                                                                                                            String[] partes = linha.split("time=");
                                                                                                                                                                String tempoStr = partes[1].split(" ")[0];
                                                                                                                                                                                    double tempo = Double.parseDouble(tempoStr);
                                                                                                                                                                                                        tempos.add(tempo);
                                                                                                                                                                                                                            System.out.println(nomeServidor + " - Tempo: " + tempo + " ms");
                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                    double media = tempos.stream().mapToDouble(Double::doubleValue).average().orElse(0);
                                                                                                                                                                                                                                                                                System.out.println(nomeServidor + " - Tempo médio: " + media + " ms");
                                                                                                                                                                                                                                                                                        } catch (Exception e) {
                                                                                                                                                                                                                                                                                                    System.out.println("Erro ao executar ping em " + nomeServidor);
                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                }

                                                                                                                                                                                                                                                                                                                    public static void main(String[] args) {
                                                                                                                                                                                                                                                                                                                            if (!System.getProperty("os.name").toLowerCase().contains("linux")) {
                                                                                                                                                                                                                                                                                                                                        System.out.println("Este programa só funciona em Linux.");
                                                                                                                                                                                                                                                                                                                                                    return;
                                                                                                                                                                                                                                                                                                                                                            }

                                                                                                                                                                                                                                                                                                                                                                    new PingThread("www.uol.com.br", "UOL").start();
                                                                                                                                                                                                                                                                                                                                                                            new PingThread("www.terra.com.br", "Terra").start();
                                                                                                                                                                                                                                                                                                                                                                                    new PingThread("www.google.com.br", "Google").start();
                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                        }